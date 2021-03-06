﻿using System;
using System.Collections.Generic;
using Backend.Models;

namespace Backend
{
    public static class DataStorage
    {
        public static readonly List<Product> Products = new List<Product>();
        public static readonly List<Order> Orders = new List<Order>();

        public static void Seed()
        {
            Products.Add(new Product
            {
                id = Guid.NewGuid(),
                name = "Kayak",
                description = "A boat for one person",
                category = "Watersports",
                price = 275
            });
            Products.Add(new Product
            {
                id = Guid.NewGuid(),
                name = "Lifejacket",
                description = "Protective and fashionable",
                category = "Watersports",
                price = 48.95
            });
            Products.Add(new Product
            {
                id = Guid.NewGuid(),
                name = "Soccer Ball",
                description = "FIFA-approved size and weight",
                category = "Soccer",
                price = 19.5
            });
            Products.Add(new Product
            {
                id = Guid.NewGuid(),
                name = "Corner Flags",
                description = "Give your playing field a professional touch",
                category = "Soccer",
                price = 34.9
            });

            Products.Add(new Product
            {
                id = Guid.NewGuid(),
                name = "Stadium",
                description = "Flat-packed 35,000-seat stadium",
                category = "Soccer",
                price = 79500.00
            });

            Products.Add(new Product
            {
                id = Guid.NewGuid(),
                name = "Thinking Cap",
                description = "Improve your brain efficiency by 75%",
                category = "Chess",
                price = 16
            });

            Products.Add(new Product
            {
                id = Guid.NewGuid(),
                name = "Unsteady Chair",
                description = "Secretly give your opponent a disadvantage",
                category = "Chess",
                price = 29.95
            });

            Products.Add(new Product
            {
                id = Guid.NewGuid(),
                name = "Human Chess Board",
                description = "A fun game for the family",
                category = "Chess",
                price = 75
            });

            Products.Add(new Product
            {
                id = Guid.NewGuid(),
                name = "Bling-Bling King",
                description = "Gold-plated, diamond-studded King",
                category = "Chess",
                price = 1200
            });
        }
    }
}