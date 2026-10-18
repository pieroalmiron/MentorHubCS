using System;
using System.Collections.Generic;
using System.Text;

namespace MentorHub.Modelo.Academico
{
    public class Curso
    {
        public Curso() { }

        public Curso (Curso Curso)
        {
            Id = Curso.Id;
            Codigo = Curso.Codigo;
            Nombre = Curso.Nombre;
            CantidadCreditos = Curso.CantidadCreditos;
            Activo = Curso.Activo;
            PeriodoAcademico = Curso.PeriodoAcademico;
            TutoresCurso = Curso.TutoresCurso;
        }

        public int Id { 
            get;
            set
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value, 0);
                field = value;
            }
        }

        public string Codigo
        {
            get;
            set
            {
                ArgumentException.ThrowIfNullOrEmpty(value);
                field = value;
            }
        }

        public string Nombre
        {
            get;
            set
            {
                ArgumentException.ThrowIfNullOrEmpty(value);
            }
        }

        public double CantidadCreditos
        {
            get;
            set
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value, 0);
                field = value;
            }
        }

        public bool Activo { get; set; }

        public PeriodoAcademico PeriodoAcademico
        {
            get;
            set
            {
                ArgumentNullException.ThrowIfNull(PeriodoAcademico);
                field = value;
            }
        }

        public IReadOnlyList<TutorCurso> TutoresCurso
        {
            get;
            set
            {
                ArgumentNullException.ThrowIfNull(value);
                field = new List<TutorCurso>(value).AsReadOnly();
            }
        } = [];

        public void AddTutor(TutorCurso TutorCurso)
        {
            TutoresCurso = TutoresCurso.Append(TutorCurso).ToList().AsReadOnly();
        }
    }
}
