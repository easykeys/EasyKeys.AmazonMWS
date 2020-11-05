/*******************************************************************************
 * Copyright 2009-2015 Amazon Services. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License");
 *
 * You may not use this file except in compliance with the License.
 * You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 * This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the
 * specific language governing permissions and limitations under the License.
 *******************************************************************************
 * Address
 * API Version: 2013-09-01
 * Library Version: 2015-09-24
 * Generated: Fri Sep 25 20:06:25 GMT 2015
 */

using EasyKeys.AmazonMWS.Runtime;

namespace EasyKeys.AmazonMWS.Orders.Model
{
    public class Address : AbstractMwsObject
    {
        /// <summary>
        /// Gets and sets the Name property.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Sets the Name property.
        /// </summary>
        /// <param name="name">Name property.</param>
        /// <returns>this instance.</returns>
        public Address WithName(string name)
        {
            Name = name;
            return this;
        }

        /// <summary>
        /// Checks if Name property is set.
        /// </summary>
        /// <returns>true if Name property is set.</returns>
        public bool IsSetName()
        {
            return Name != null;
        }

        /// <summary>
        /// Gets and sets the AddressLine1 property.
        /// </summary>
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Sets the AddressLine1 property.
        /// </summary>
        /// <param name="addressLine1">AddressLine1 property.</param>
        /// <returns>this instance.</returns>
        public Address WithAddressLine1(string addressLine1)
        {
            AddressLine1 = addressLine1;
            return this;
        }

        /// <summary>
        /// Checks if AddressLine1 property is set.
        /// </summary>
        /// <returns>true if AddressLine1 property is set.</returns>
        public bool IsSetAddressLine1()
        {
            return AddressLine1 != null;
        }

        /// <summary>
        /// Gets and sets the AddressLine2 property.
        /// </summary>
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Sets the AddressLine2 property.
        /// </summary>
        /// <param name="addressLine2">AddressLine2 property.</param>
        /// <returns>this instance.</returns>
        public Address WithAddressLine2(string addressLine2)
        {
            AddressLine2 = addressLine2;
            return this;
        }

        /// <summary>
        /// Checks if AddressLine2 property is set.
        /// </summary>
        /// <returns>true if AddressLine2 property is set.</returns>
        public bool IsSetAddressLine2()
        {
            return AddressLine2 != null;
        }

        /// <summary>
        /// Gets and sets the AddressLine3 property.
        /// </summary>
        public string AddressLine3 { get; set; }

        /// <summary>
        /// Sets the AddressLine3 property.
        /// </summary>
        /// <param name="addressLine3">AddressLine3 property.</param>
        /// <returns>this instance.</returns>
        public Address WithAddressLine3(string addressLine3)
        {
            AddressLine3 = addressLine3;
            return this;
        }

        /// <summary>
        /// Checks if AddressLine3 property is set.
        /// </summary>
        /// <returns>true if AddressLine3 property is set.</returns>
        public bool IsSetAddressLine3()
        {
            return AddressLine3 != null;
        }

        /// <summary>
        /// Gets and sets the City property.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Sets the City property.
        /// </summary>
        /// <param name="city">City property.</param>
        /// <returns>this instance.</returns>
        public Address WithCity(string city)
        {
            City = city;
            return this;
        }

        /// <summary>
        /// Checks if City property is set.
        /// </summary>
        /// <returns>true if City property is set.</returns>
        public bool IsSetCity()
        {
            return City != null;
        }

        /// <summary>
        /// Gets and sets the County property.
        /// </summary>
        public string County { get; set; }

        /// <summary>
        /// Sets the County property.
        /// </summary>
        /// <param name="county">County property.</param>
        /// <returns>this instance.</returns>
        public Address WithCounty(string county)
        {
            County = county;
            return this;
        }

        /// <summary>
        /// Checks if County property is set.
        /// </summary>
        /// <returns>true if County property is set.</returns>
        public bool IsSetCounty()
        {
            return County != null;
        }

        /// <summary>
        /// Gets and sets the District property.
        /// </summary>
        public string District { get; set; }

        /// <summary>
        /// Sets the District property.
        /// </summary>
        /// <param name="district">District property.</param>
        /// <returns>this instance.</returns>
        public Address WithDistrict(string district)
        {
            District = district;
            return this;
        }

        /// <summary>
        /// Checks if District property is set.
        /// </summary>
        /// <returns>true if District property is set.</returns>
        public bool IsSetDistrict()
        {
            return District != null;
        }

        /// <summary>
        /// Gets and sets the StateOrRegion property.
        /// </summary>
        public string StateOrRegion { get; set; }

        /// <summary>
        /// Sets the StateOrRegion property.
        /// </summary>
        /// <param name="stateOrRegion">StateOrRegion property.</param>
        /// <returns>this instance.</returns>
        public Address WithStateOrRegion(string stateOrRegion)
        {
            StateOrRegion = stateOrRegion;
            return this;
        }

        /// <summary>
        /// Checks if StateOrRegion property is set.
        /// </summary>
        /// <returns>true if StateOrRegion property is set.</returns>
        public bool IsSetStateOrRegion()
        {
            return StateOrRegion != null;
        }

        /// <summary>
        /// Gets and sets the PostalCode property.
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// Sets the PostalCode property.
        /// </summary>
        /// <param name="postalCode">PostalCode property.</param>
        /// <returns>this instance.</returns>
        public Address WithPostalCode(string postalCode)
        {
            PostalCode = postalCode;
            return this;
        }

        /// <summary>
        /// Checks if PostalCode property is set.
        /// </summary>
        /// <returns>true if PostalCode property is set.</returns>
        public bool IsSetPostalCode()
        {
            return PostalCode != null;
        }

        /// <summary>
        /// Gets and sets the CountryCode property.
        /// </summary>
        public string CountryCode { get; set; }

        /// <summary>
        /// Sets the CountryCode property.
        /// </summary>
        /// <param name="countryCode">CountryCode property.</param>
        /// <returns>this instance.</returns>
        public Address WithCountryCode(string countryCode)
        {
            CountryCode = countryCode;
            return this;
        }

        /// <summary>
        /// Checks if CountryCode property is set.
        /// </summary>
        /// <returns>true if CountryCode property is set.</returns>
        public bool IsSetCountryCode()
        {
            return CountryCode != null;
        }

        /// <summary>
        /// Gets and sets the Phone property.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Sets the Phone property.
        /// </summary>
        /// <param name="phone">Phone property.</param>
        /// <returns>this instance.</returns>
        public Address WithPhone(string phone)
        {
            Phone = phone;
            return this;
        }

        /// <summary>
        /// Checks if Phone property is set.
        /// </summary>
        /// <returns>true if Phone property is set.</returns>
        public bool IsSetPhone()
        {
            return Phone != null;
        }

        public override void ReadFragmentFrom(IMwsReader reader)
        {
            Name = reader.Read<string>("Name");
            AddressLine1 = reader.Read<string>("AddressLine1");
            AddressLine2 = reader.Read<string>("AddressLine2");
            AddressLine3 = reader.Read<string>("AddressLine3");
            City = reader.Read<string>("City");
            County = reader.Read<string>("County");
            District = reader.Read<string>("District");
            StateOrRegion = reader.Read<string>("StateOrRegion");
            PostalCode = reader.Read<string>("PostalCode");
            CountryCode = reader.Read<string>("CountryCode");
            Phone = reader.Read<string>("Phone");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("Name", Name);
            writer.Write("AddressLine1", AddressLine1);
            writer.Write("AddressLine2", AddressLine2);
            writer.Write("AddressLine3", AddressLine3);
            writer.Write("City", City);
            writer.Write("County", County);
            writer.Write("District", District);
            writer.Write("StateOrRegion", StateOrRegion);
            writer.Write("PostalCode", PostalCode);
            writer.Write("CountryCode", CountryCode);
            writer.Write("Phone", Phone);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("https://mws.amazonservices.com/Orders/2013-09-01", "Address", this);
        }

        public Address() : base()
        {
        }
    }
}
