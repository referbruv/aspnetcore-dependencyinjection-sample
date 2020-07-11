using System;
using System.Collections.Generic;
using DiReadersApp.Models;

namespace DiReadersApp.Providers.Context
{
    public interface IReadersContext
    {
        IEnumerable<Reader> Readers { get; }
    }

    public class FakeReadersContext : IReadersContext
    {
        private readonly IEnumerable<Reader> _readers;

        public FakeReadersContext()
        {
            _readers = Seed();
        }

        private IEnumerable<Reader> Seed()
        {
            return new List<Reader>() {
                new Reader {
                    Id = 1001,
                    Name = "Reader1001",
                    EmailAddress = "reader1001@abc.com",
                    AddedOn = DateTime.Now
                },
                new Reader {
                    Id = 1002,
                    Name = "Reader1002",
                    EmailAddress = "reader1002@abc.com",
                    AddedOn = DateTime.Now
                },
                new Reader {
                    Id = 1003,
                    Name = "Reader1003",
                    EmailAddress = "reader1003@abc.com",
                    AddedOn = DateTime.Now
                },
                new Reader {
                    Id = 1004,
                    Name = "Reader1004",
                    EmailAddress = "reader1004@abc.com",
                    AddedOn = DateTime.Now
                },
                new Reader {
                    Id = 1005,
                    Name = "Reader1005",
                    EmailAddress = "reader1005@abc.com",
                    AddedOn = DateTime.Now
                }
            };
        }

        public IEnumerable<Reader> Readers => _readers;
    }
}