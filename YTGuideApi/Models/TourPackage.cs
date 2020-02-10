using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YTGuideApi.Models
{
    public class TourPackage
    {
       
        public string id { get; set; }
        public int agentId { get; set; }
        public string title { get; set; }
        public string slug { get; set; }
        public string content { get; set; }
        public string status { get; set; }
        public string price { get; set; }
        public bool isNegotiable { get; set; }
        public string propertyType { get; set; }
        public string condition { get; set; }
        public int rating { get; set; }
        public int ratingCount { get; set; }
        public string contactNumber { get; set; }
        public string termsAndCondition { get; set; }
        public Amenity[] amenities { get; set; }
        public Image image { get; set; }
        public Location location { get; set; }
        public Gallery[] gallery { get; set; }
        public Category[] categories { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }


        public class Image
        {
            public int id { get; set; }
            public string url { get; set; }
            public string thumb_url { get; set; }
        }

        public class Location
        {
            public int id { get; set; }
            public float lat { get; set; }
            public float lng { get; set; }
            public string formattedAddress { get; set; }
            public string zipcode { get; set; }
            public string city { get; set; }
            public string state_long { get; set; }
            public string state_short { get; set; }
            public string country_long { get; set; }
            public string country_short { get; set; }
        }

        public class Amenity
        {
            public int id { get; set; }
            public int guestRoom { get; set; }
            public int bedRoom { get; set; }
            public bool wifiAvailability { get; set; }
            public bool parkingAvailability { get; set; }
            public bool poolAvailability { get; set; }
            public bool airCondition { get; set; }
            public bool extraBedFacility { get; set; }
        }

        public class Gallery
        {
            public int id { get; set; }
            public string url { get; set; }
        }

        public class Category
        {
            public int id { get; set; }
            public string slug { get; set; }
            public string name { get; set; }
            public CategoryImages image { get; set; }
        }

        public class CategoryImages
        {
            public int id { get; set; }
            public string url { get; set; }
        }

    }
}
