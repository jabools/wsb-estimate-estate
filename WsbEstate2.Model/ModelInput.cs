//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************

using Microsoft.ML.Data;

namespace WsbEstate2.Model
{
    public class ModelInput
    {
        [ColumnName("SoldPrice"), LoadColumn(0)]
        public float SoldPrice { get; set; }


        [ColumnName("Type"), LoadColumn(1)]
        public string Type { get; set; }


        [ColumnName("YearBuilt"), LoadColumn(2)]
        public string YearBuilt { get; set; }


        [ColumnName("Area"), LoadColumn(3)]
        public float Area { get; set; }


        [ColumnName("Zip"), LoadColumn(4)]
        public float Zip { get; set; }


        [ColumnName("Baths"), LoadColumn(5)]
        public float Baths { get; set; }


        [ColumnName("Beds"), LoadColumn(6)]
        public string Beds { get; set; }


        [ColumnName("GarageType"), LoadColumn(7)]
        public string GarageType { get; set; }


        [ColumnName("GarageSpaces"), LoadColumn(8)]
        public string GarageSpaces { get; set; }


        [ColumnName("ParkingSpaces"), LoadColumn(9)]
        public float ParkingSpaces { get; set; }


    }
}
