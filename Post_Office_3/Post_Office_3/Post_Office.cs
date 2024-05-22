using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Post_Office_3.Data;
using System.Globalization;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Reflection.Emit;

namespace Post_Office_3
{
    public partial class Post_Office : MaterialForm
    {
        private readonly AppDbContext _context;
        public Post_Office()
        {
            InitializeComponent();
            _context = new AppDbContext();
            //Dispose context after Form is closing
            this.FormClosed += new FormClosedEventHandler(Form1_FormClosed);

            void Form1_FormClosed(object sender, FormClosedEventArgs e)
            {
                Dispose();
            }

        }

        //Function for Dispose context after Form is closing
        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();

            }
        }
        private void Post_Office_Load(object sender, EventArgs e)
        {

        }

        private void send_Click(object sender, EventArgs e)
        {
            //Get data from field 
            int weight = int.Parse(weightF.Text);
            DateTime dateSend = DateTime.Parse(datesendF.Text);
            DateTime dateCome = DateTime.Parse(datecomeF.Text);
            decimal price = decimal.Parse(priceF.Text);

            //Form string for writing in file 
            string data = $"{weight}, {dateSend}, {dateCome}, {price}";

            //Write data inside file with succor static-class FileHelper 
            FileHelper.WriteToFile("E:\\Student\\Post_Office_3\\Post_Office_3.Data\\INFO.TXT", data);

            //Clear text Fields 
            weightF.Clear();
            datesendF.Clear();
            datecomeF.Clear();
            priceF.Clear();

            MessageBox.Show("Horay, parcel sended!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void read_Click(object sender, EventArgs e)
        {
            // read data from file
            List<string> parcelInfo = new List<string>();

            using (StreamReader reader = new StreamReader("E:\\Student\\Post_Office_3\\Post_Office_3.Data\\INFO.TXT"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    parcelInfo.Add(line);
                }
            }

            // Sorted data by date come
            List<string> sortedStudentInfo = parcelInfo.OrderBy(s =>
            {
                string[] parts = s.Split(',');
                if (parts.Length >= 3 && parts.Length < 4)
                {
                    return DateTime.ParseExact(parts[2].Trim(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
                }
                else
                {
                    return DateTime.MaxValue;
                }
            }).ToList();

            string sortedInfo = string.Join(Environment.NewLine, sortedStudentInfo);

            MessageBox.Show("Parcels list:\n\n" + sortedInfo, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddParcelToDb_Click(object sender, EventArgs e)
        {

            try
            {
                // Get data from field 
                int weight = int.Parse(weightF.Text);
                DateTime dateSend = DateTime.Parse(datesendF.Text);
                DateTime dateCome = DateTime.Parse(datecomeF.Text);
                decimal price = decimal.Parse(priceF.Text);

                //Create new object Parcel with input data 
                var parcel = new Post_Office_3.Data.Parcel(weight, dateSend, dateCome, price)
                {
                    Weight = weight,
                    DateSend = dateSend,
                    DateCome = dateCome,
                    Price = price,
                    //CreatedAt = DateTime.Now 
                };

                // Add parcel to context DB 
                _context.Parcels.Add(parcel);

                // Save changes in DB 
                _context.SaveChanges();

                MessageBox.Show("Parcel added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                


                weightF.Clear();
                datesendF.Clear();
                datecomeF.Clear();
                priceF.Clear();


                
            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);
                MessageBox.Show("Error adding parcel. Please check input data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReadParcelFromDb_Click(object sender, EventArgs e)
        {
            try
            {
                // Query the Parcels DbSet and sort by DateSend
                var sortedParcels = _context.Parcels
                    .OrderBy(p => p.DateSend)
                    .ToList();

                if (sortedParcels.Any())
                {
                    // Prepare the sorted information for display
                    var sortedInfo = string.Join(Environment.NewLine, sortedParcels.Select(p =>
                        $"Weight: {p.Weight}, DateSend: {p.DateSend}, DateCome: {p.DateCome}, Price: {p.Price}"
                    ));

                    MessageBox.Show("Sorted Parcels by DateSend:\n\n" + sortedInfo, "Sorted Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No parcels found in the database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);
                MessageBox.Show("Error reading and sorting parcels. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WeightMoreThan10_Click(object sender, EventArgs e)
        {

            try
            {
                // Query the Parcels DbSet and sort by DateSend
                var sortedParcels = _context.Parcels
                    .OrderBy(p => p.DateSend)
                    .Where(p => p.Weight > 10)
                    .ToList();

                if (sortedParcels.Any())
                {
                    // Filter parcels by weight (> 10)
                    var heavyParcels = sortedParcels;//.Where(p => p.Weight > 10);

                    if (heavyParcels.Any())
                    {
                        // Prepare the filtered information for display
                        var filteredInfo = string.Join(Environment.NewLine, heavyParcels.Select(p =>
                            $"Weight: {p.Weight}, DateSend: {p.DateSend}, DateCome: {p.DateCome}, Price: {p.Price}"
                        ));

                        MessageBox.Show("Heavy Parcels (> 10kg):\n\n" + filteredInfo, "Filtered Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No heavy parcels (> 10kg) found in the database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No parcels found in the database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);
                MessageBox.Show("Error filtering parcels. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PriceMoreThan100_Click(object sender, EventArgs e)
        {
            try
            {
                // Query the Parcels DbSet and sort by DateSend
                var sortedParcels = _context.Parcels
                    .OrderBy(p => p.DateSend)
                    .Where(p => p.Price > 100)
                    .ToList();

                if (sortedParcels.Any())
                {
                    // Filter parcels by weight (> 10)
                    var expensiveParcelExists = sortedParcels;//.Where(p => p.Price > 100);

                    if (expensiveParcelExists.Any())
                    {
                        // Prepare the filtered information for display
                        var filteredInfo = string.Join(Environment.NewLine, expensiveParcelExists.Select(p =>
                            $"Weight: {p.Weight}, DateSend: {p.DateSend}, DateCome: {p.DateCome}, Price: {p.Price}"
                        ));

                        MessageBox.Show(" Expensive parcel exists (> 100):\n\n" + filteredInfo, "Filtered Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No expensive parcel  (> 100) found in the database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No parcels found in the database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);
                MessageBox.Show("Error filtering parcels. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Average_Click(object sender, EventArgs e)
        {
            try
            {
                // Query the Parcels DbSet and sort by DateSend
                var sortedParcels = _context.Parcels
                    .OrderBy(p => p.DateSend)
                    .ToList();


                if (sortedParcels.Any())
                {
                    // Filter parcels by weight (> 10)

                    var averageWeight = sortedParcels.Average(p => p.Weight);

                    if (averageWeight != 0)
                    {

                        MessageBox.Show(" Average Weight:\n\n" + averageWeight, "Filtered Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(" Average Weight = 0 ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No parcels found in the database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);
                MessageBox.Show("Error filtering parcels. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateParcelInDbButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the ParcelId from the input field
                int parcelId = int.Parse(parcelIdF.Text); // Add a TextBox for ParcelId

                // Find the parcel by ParcelId
                var parcelToUpdate = _context.Parcels.FirstOrDefault(p => p.Id == parcelId);

                if (parcelToUpdate != null)
                {
                    // Get new data from input fields
                    int weight = int.Parse(weightF.Text);
                    DateTime dateSend = DateTime.Parse(datesendF.Text);
                    DateTime dateCome = DateTime.Parse(datecomeF.Text);
                    decimal price = decimal.Parse(priceF.Text);

                    // Update the parcel properties
                    parcelToUpdate.Weight = weight;
                    parcelToUpdate.DateSend = dateSend;
                    parcelToUpdate.DateCome = dateCome;
                    parcelToUpdate.Price = price;

                    // Save changes to the database
                    _context.SaveChanges();

                    MessageBox.Show("Parcel updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear the input fields after updating the parcel
                    parcelIdF.Clear();
                    weightF.Clear();
                    datesendF.Clear();
                    datecomeF.Clear();
                    priceF.Clear();
                }
                else
                {
                    MessageBox.Show("Parcel not found. Please check the Parcel ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);
                MessageBox.Show("Error updating parcel. Please check input data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteParcelFromDbButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the ParcelId from the input field
                int parcelId = int.Parse(parcelIdF.Text); // Add a TextBox for ParcelId

                // Find the parcel by ParcelId
                var parcelToDelete = _context.Parcels.FirstOrDefault(p => p.Id == parcelId);

                if (parcelToDelete != null)
                {
                    // Remove the parcel from the database
                    _context.Parcels.Remove(parcelToDelete);

                    // Save changes to the database
                    _context.SaveChanges();

                    MessageBox.Show("Parcel deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear the input field after deleting the parcel
                    parcelIdF.Clear();
                }
                else
                {
                    MessageBox.Show("Parcel not found. Please check the Parcel ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);
                MessageBox.Show("Error deleting parcel. Please check input data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LastParclelF_Click(object sender, EventArgs e)
        {
            try
            {
                // Get today's date
                DateTime today = DateTime.Today;
                DateTime threeDaysFromToday = today.AddDays(3);

                // Query parcels with DateCome within the next 3 days
                var parcelsInRange = _context.Parcels
                    .Where(p => p.DateCome >= today && p.DateCome <= threeDaysFromToday)
                    .OrderBy(p => p.DateCome)
                    .ToList();

                if (parcelsInRange.Any())
                {
                    // Prepare the information for display
                    var info = string.Join(Environment.NewLine, parcelsInRange.Select(p =>
                        $"Weight: {p.Weight}, DateSend: {p.DateSend}, DateCome: {p.DateCome}, Price: {p.Price}"
                    ));

                    MessageBox.Show("Parcels arriving within 3 days:\n\n" + info, "Parcels in Range", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No parcels found arriving within 3 days.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);
                MessageBox.Show("Error retrieving parcels. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
    }
}
