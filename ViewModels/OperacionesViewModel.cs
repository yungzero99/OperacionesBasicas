using OperacionesBasicas.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace OperacionesBasicas.ViewModels
{
    internal class OperacionesViewModel : INotifyPropertyChanged
    {
        private Operacion OperacionesBasicas;


        public int Count
        {
            get => OperacionesBasicas._count;
            set
            {
                if (OperacionesBasicas._count != value)
                {
                    OperacionesBasicas._count = value;
                    OnPropertyChanged();
                }
            }
        }

        public double Numero1
        {
            get => OperacionesBasicas._numero1;
            set
            {
                OperacionesBasicas._numero1 = value;
                SumarCommand.Execute(null);
                RestarCommand.Execute(null);
                MultiplicarCommand.Execute(null);
                DividirCommand.Execute(null);
                OnPropertyChanged();
            }
        }
        public double Numero2
        {
            get => OperacionesBasicas._numero2;
            set
            {
                OperacionesBasicas._numero2 = value;
                SumarCommand.Execute(null);
                RestarCommand.Execute(null);
                MultiplicarCommand.Execute(null);
                DividirCommand.Execute(null);
                OnPropertyChanged();
            }
        }

        public double Suma
        {
            get => OperacionesBasicas.Suma;
            set
            {
                OperacionesBasicas.Suma = value;
                OnPropertyChanged();
            }
        }
        public double Resta
        {
            get => OperacionesBasicas.Resta;
            set
            {
                OperacionesBasicas.Resta = value;
                OnPropertyChanged();
            }
        }
        public double Multiplicacion
        {
            get => OperacionesBasicas.Multiplicacion;
            set
            {
                OperacionesBasicas.Multiplicacion = value;
                OnPropertyChanged();
            }
        }
        public double Division
        {
            get => OperacionesBasicas.Division;
            set
            {
                OperacionesBasicas.Division = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
     //   public Operacion Operaciones { get; set; }
        public ICommand SumarCommand { get; }
        public ICommand RestarCommand { get; }
        public ICommand MultiplicarCommand { get; }
        public ICommand DividirCommand { get; }
        public ICommand IncrementCommand { get; }
        public ICommand DecrementCommand { get; }

        public OperacionesViewModel()
        {
            OperacionesBasicas = new Operacion();

            SumarCommand = new Command(Sumar);
            RestarCommand = new Command(Restar);
            MultiplicarCommand = new Command(Multiplicar);
            DividirCommand = new Command(Dividir);
            IncrementCommand = new Command(Increment);
            DecrementCommand = new Command(Decrement);
        }


        private void Decrement()
        {
            OperacionesBasicas.Decrement();
            OnPropertyChanged(nameof(Count));
        }
        private void Increment()
        {
            OperacionesBasicas.Increment();
            OnPropertyChanged(nameof(Count));
        }
        private void Sumar()
        {
            OperacionesBasicas.Sumar();
            OnPropertyChanged(nameof(Suma));
        }

        private void Restar()
        {
            OperacionesBasicas.Restar();
            OnPropertyChanged(nameof(Resta));
        }

        private void Multiplicar()
        {
            OperacionesBasicas.Multiplicar();
            OnPropertyChanged(nameof(Multiplicacion));
        }

        private void Dividir()
        {
            OperacionesBasicas.Dividir();
            OnPropertyChanged(nameof(Division));
        }
    }
}
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.



/*

        public Operacion Operaciones { get; set; }
        public ICommand SumarCommand { get; }
        public ICommand RestarCommand { get; }
        public ICommand MultiplicarCommand { get; }
        public ICommand DividirCommand { get; }
*/