using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9
{
    public class DeliveryAddressBuilder
    {
        private Address _address = new();
        public DeliveryAddressBuilder WithCountry(string country) 
        {
            _address = _address with { Country = country };
            return this;
        }
        public DeliveryAddressBuilder WithRegion(string region)
        {
            _address = _address with { Region = region };
            return this;
        }

        public DeliveryAddressBuilder WithCity(string city)
        {
            _address = _address with { City = city };
            return this;
        }
        public DeliveryAddressBuilder WithIndex(string index)
        {
            _address = _address with { Index = index };
            return this;
        }
        public DeliveryAddressBuilder WithStreet(string street)
        {
            _address = _address with { Street = street };
            return this;
        }
        public DeliveryAddressBuilder WithHouse(string house)
        {
            _address = _address with { House = house };
            return this;
        }
        public DeliveryAddressBuilder WithApartment(string apartment)
        {
            _address = _address with { Apartment = apartment };
            return this;
        }

        public Address Build() => _address;

    }
    public record Address()
    {
        public string? Country { get; init; }
        public string? Region { get; init; }
        public string? City { get; init; }
        public string? Index { get; init; }
        public string? Street { get; init; }
        public string? House { get; init; }
        public string? Apartment { get; init; }
    }
}


