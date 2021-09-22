using Domain.Models;
using Domain.Repository;
using Infrastructure.EF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private DatabaseContext _context;
        public StudentRepository(DatabaseContext context)
        {
            this._context = context;
        }
        public Student Create(Student entity)
        {
            var student = _context.Students.Add(entity);
            _context.SaveChanges();
            return student.Entity;
        }

        public void Delete(int id)
        {
            var student = _context.Students.FirstOrDefault(x => x.Id == id);
            _context.Students.Remove(student);
            _context.SaveChanges();
        }

        public Student Get(int id)
        {
            return _context.Students.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<Student> GetAll()
        {
            return _context.Students.AsNoTracking();
        }

        public Student Update(Student entity)
        {
            var student = _context.Students.Update(entity);
            _context.SaveChanges();
            return student.Entity;
        }
    }
}
