using System;
using System.Collections.Generic;
using System.Text;

namespace MentorHub.Modelo.Academico
{
    public class PeriodoAcademico
    {
        public PeriodoAcademico() { }

        public PeriodoAcademico(PeriodoAcademico PeriodoAcademico)
        {
            Id = PeriodoAcademico.Id;
            Nombre = PeriodoAcademico.Nombre;
            FechaInicio = PeriodoAcademico.FechaInicio;
            FechaFin = PeriodoAcademico.FechaFin;
            EstadoPeriodo = PeriodoAcademico.EstadoPeriodo;
            Cursos = PeriodoAcademico.Cursos;
        }

        public int Id
        {
            get;
            set
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value, 0);
                field = value;
            }
        }

        public string Nombre
        {
            get;
            set
            {
                ArgumentException.ThrowIfNullOrEmpty(value);
                field = value;
            }
        }

        public DateTime FechaInicio { get; set; }

        public DateTime? FechaFin { get; set; }

        public EstadoPeriodo EstadoPeriodo
        {
            get;
            set
            {
                ArgumentNullException.ThrowIfNull(value);
                field = value;
            }
        }

        public IReadOnlyList<Curso> Cursos
        {
            get;
            set
            {
                ArgumentNullException.ThrowIfNull(value);
                field = new List<Curso>(value).AsReadOnly();
            }
        } = [];

        public void AddCurso(Curso Curso)
        {
            ArgumentNullException.ThrowIfNull(Curso);
            Cursos = Cursos.Append(Curso).ToList().AsReadOnly();
        }
    }
}
