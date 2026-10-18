using System;
using System.Collections.Generic;
using System.Text;

namespace MentorHub.Modelo.Academico
{
    public class TutorCurso
    {
        public TutorCurso() { }
        public TutorCurso(TutorCurso TutorCurso)
        {

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

        public Tutor? Tutor
        {
            get
            {
                return field != null ? new Tutor(field) : null;
            }
            set
            {
                field = value != null ? new Tutor(value) : null;
            }
        }

        public Curso? Curso
        {
            get
            {
                return field != null ? new Curso(field) : null;
            }
            set
            {
                field = value != null ? new Curso(value) : null;
            }
        }

        public double Nota
        {
            get;
            set
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value, 0);
                field = value;
            }
        }

        public EstadoDictadoCurso EstadoDictadoCurso { get; set; }
    }
}
