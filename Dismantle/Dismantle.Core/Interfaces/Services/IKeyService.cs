﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dismantle.Core.Interfaces.Services
{
    public interface IKeyService
    {
        string ConstructFilmKey(string title, short year);
        string ConstructFilmPersonKey(string title,
                                      short year,
                                      string lastName,
                                      string birthdate,
                                      string role);
        string ConstructMediumKey(string title,
                                  short year,
                                  string mediumType);
        string ConstructPersonKey(string lastName, string birthdate);
        (string title, short year) DeconstructFilmKey(string key);
        (string title, short year, string lastName, string birthdate, string role) DeconstructFilmPersonKey(string key);
        (string title, short year, string mediumType) DeconstructMediumKey(string key);
        (string lastName, string birthdate) DeconstructPersonKey(string key);
    }
}
