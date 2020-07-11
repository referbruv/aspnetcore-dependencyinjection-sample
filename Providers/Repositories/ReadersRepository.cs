using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DiReadersApp.Models;
using DiReadersApp.Providers.Context;

namespace DiReadersApp.Providers.Repositories
{
    public interface IReadersRepository
    {
        IEnumerable<Reader> Get(Func<Reader, bool> predicate);
    }

    public class PlainReadersRepository : IReadersRepository
    {
        public IEnumerable<Reader> Get(Func<Reader, bool> predicate)
        {
            var context = new FakeReadersContext();
            return context.Readers.Where(predicate);
        }
    }

    public class ReadersRepository : IReadersRepository
    {
        IReadersContext _context;

        public ReadersRepository(IReadersContext context)
        {
            _context = context;
        }

        public IEnumerable<Reader> Get(Func<Reader, bool> predicate)
        {
            return _context.Readers.Where(predicate);
        }
    }
}