﻿using BookApiProject.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BookGUI.Services
{
    public class CountryRepositoryGUI : ICountryRepositoryGUI
    {
        public IEnumerable<AuthorDto> GetAuthorsFromACountry(int countryId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CountryDto> GetCountries()
        {
            IEnumerable<CountryDto> countries = new List<CountryDto>();

            // HttpClient contains all the methods and properties needed to make API calls.
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:60039/api/");
            }

            return countries;
        }

        public CountryDto GetCountryById(int countryId)
        {
            throw new NotImplementedException();
        }

        public CountryDto GetCountryOfAnAuthor(int authorId)
        {
            throw new NotImplementedException();
        }
    }
}
