using BooksShop.DAL.Entities;
using BooksShop.DAL.Repositories;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksShop.DAL.Seeding
{
    public class MainPhotoSeeder:ISeeder<MainPhoto>
    {
        private static readonly List<MainPhoto> mainPhotos = new List<MainPhoto>()
        {
            new MainPhoto
            {
                Id = 1,
                path = "shinig.jpg"
            }, new MainPhoto
            {
                Id = 2,
                path = "drSleep.jpg"
            }, new MainPhoto
            {
                Id = 3,
                path = "Psycho.jpg"
            }, new MainPhoto
            {
                Id = 4,
                path = "PetSematary.jpg"
            }, new MainPhoto
            {
                Id = 5,
                path = "It.jpg"
            }, new MainPhoto
            {
                Id = 6,
                path = "joyland.jpg"
            }, new MainPhoto
            {
                Id = 7,
                path = "joyland.jpg"
            }, new MainPhoto
            {
                Id = 8,
                path = "outsider.jpg"
            }, new MainPhoto
            {
                Id = 9,
                path = "outsider.jpg"
            }, new MainPhoto
            {
                Id = 10,
                path = "joyland.jpg"
            }, new MainPhoto
            {
                Id = 11,
                path = "lotr.jpg"
            }, new MainPhoto
            {
                Id = 12,
                path = "hpp.jpg"
            }, new MainPhoto
            {
                Id = 13,
                path = "hpch.jpg"
            }, new MainPhoto
            {
                Id = 14,
                path = "hppa.jpg"
            }, new MainPhoto
            {
                Id = 15,
                path = "hpgf.jpg"
            }, new MainPhoto
            {
                Id = 16,
                path = "hpop.jpg"
            }, new MainPhoto
            {
                Id = 17,
                path = "hphbp.jpg"
            }, new MainPhoto
            {
                Id = 18,
                path = "hpdh.jpg"
            }
        };

        public void Seed(EntityTypeBuilder<MainPhoto> builder) => builder.HasData(mainPhotos);
    }
}
