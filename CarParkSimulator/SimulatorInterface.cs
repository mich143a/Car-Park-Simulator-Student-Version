using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarParkSimulator
{
    public partial class SimulatorInterface : Form
    {
        // Attributes ///        
        private TicketMachine ticketMachine;
        private ActiveTickets activeTickets;
        private TicketValidator ticketValidator;
        private Barrier entryBarrier;
        private Barrier exitBarrier;
        private FullSign fullSign;
        private CarPark carPark;
        private EntrySensor entrySensor;
        private ExitSensor exitSensor;
        /////////////////


        // Constructor //
        public SimulatorInterface()
        {
            InitializeComponent();
        }
        /////////////////


        // Operations ///
        private void ResetSystem(object sender, EventArgs e)
        {
            // STUDENTS:
            ///// Class contructors are not defined so there will be errors
            ///// This code is correct for the basic version though
            activeTickets = new ActiveTickets();
            ticketMachine = new TicketMachine(activeTickets);
            ticketValidator = new TicketValidator(activeTickets);
            entryBarrier = new Barrier();
            exitBarrier = new Barrier();
            fullSign = new FullSign();
            carPark = new CarPark(ticketMachine, ticketValidator, fullSign, entryBarrier, exitBarrier);
            entrySensor = new EntrySensor(carPark);
            exitSensor = new ExitSensor(carPark);

            ticketMachine.AssignCarPark(carPark);
            ticketValidator.AssignCarPark(carPark);

            /////////////////////////////////////////

            btnCarArrivesAtEntrance.Visible = true;
            btnDriverPressesForTicket.Visible = false;
            btnCarEntersCarPark.Visible = false;
            btnCarArrivesAtExit.Visible = false;
            btnDriverEntersTicket.Visible = false;
            btnCarExitsCarPark.Visible = false;

            UpdateDisplay();
        }

        private void CarArrivesAtEntrance(object sender, EventArgs e)
        {
            entrySensor.CarDetected();
            btnCarArrivesAtEntrance.Visible = false;
            btnDriverPressesForTicket.Visible = true;
            UpdateDisplay();
        }

        private void DriverPressesForTicket(object sender, EventArgs e)
        {
            ticketMachine.PrintTicket();
            btnDriverPressesForTicket.Visible = false;
            btnCarEntersCarPark.Visible = true;
            UpdateDisplay();
        }

        private void CarEntersCarPark(object sender, EventArgs e)
        {
            entrySensor.CarLeftSensor();
            btnCarEntersCarPark.Visible = false;
            btnCarArrivesAtExit.Visible = true;

            if (carPark.IsFull() == false)
            {
                btnCarArrivesAtEntrance.Visible = true;
            }
            else btnCarArrivesAtEntrance.Visible = false;
            UpdateDisplay();
        }

        private void CarArrivesAtExit(object sender, EventArgs e)
        {
            exitSensor.CarDetected();
            btnCarArrivesAtExit.Visible = false;
            btnDriverEntersTicket.Visible = true;
            UpdateDisplay();
        }

        private void DriverEntersTicket(object sender, EventArgs e)
        {
            ticketValidator.TicketEntered();
            btnDriverEntersTicket.Visible = false;
            btnCarExitsCarPark.Visible = true;
            UpdateDisplay();

        }

        private void CarExitsCarPark(object sender, EventArgs e)
        {
            exitSensor.CarLeftSensor();
            btnCarExitsCarPark.Visible = false;
            btnCarArrivesAtEntrance.Visible = true;
            if (carPark.IsEmpty() == false)
            {
                btnCarArrivesAtExit.Visible = true;
            }
            else btnCarArrivesAtExit.Visible = false;
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            lblEntrySensor.Text = entrySensor.IsCarOnSensor().ToString();
            lblExitSensor.Text = exitSensor.IsCarOnSensor().ToString();
            lblSpaces.Text = carPark.GetCurrentSpaces().ToString();
            lblFullSign.Text = fullSign.isLit().ToString();
            lblExitBarrier.Text = exitBarrier.IsLifted().ToString();
            lblEntryBarrier.Text = entryBarrier.IsLifted().ToString();
            lblTicketMachine.Text = ticketMachine.GetMessage();
            lblTicketValidator.Text = ticketValidator.GetMessage();

            lstActiveTickets.Items.Clear();
            List<Ticket> tickets = activeTickets.GetTickets();
            foreach (Ticket ticket in tickets){
                lstActiveTickets.Items.Add(ticket.GetHashCode());
            }
        }
    }
}
