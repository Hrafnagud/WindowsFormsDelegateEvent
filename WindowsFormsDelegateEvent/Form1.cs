using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDelegateEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void GreetingHello()
        {
            MessageBox.Show("Hello!");
        }

        public int Addition(int fNumber, int sNumber)
        {
            return fNumber + sNumber;
        }

        public int Multiplication(int fNumber, int sNumber)
        {
            return fNumber * sNumber;
        }

        public delegate void TaskHandler();

        public delegate int OperationHandler(int fNumber, int sNumber);



        private void Form1_Load(object sender, EventArgs e)
        {
            //GreetingHello();  //Standart method invocation.

            //Let's our delegate invoke GreetingHello() method.

            //TaskHandler myTaskHandler = new TaskHandler(GreetingHello);

            //First approach for invoking method through delegate.
            //myTaskHandler();
            //Second approach for invoking method through delegate.
            //myTaskHandler.Invoke();
            //Third approach for invoking method through delegate.
            //BeginInvoke(myTaskHandler);

            btnIsClicked.Click += new EventHandler(btnIsClicked_Click);
            btnIsClicked.MouseMove += new MouseEventHandler(btnIsClicked_CursorOnButton);
            //btnIsClicked.Paint += new PaintEventHandler(btnIsClicked_Paint);

            // Event'ların tipi delegelerdir.
            //+= ile bir event oluşturmak istediğinizde event tanımlanırken tip olarak hangi delege verildiyse kendisine o delege geliyor
            // Delegenin imzası yani geriye dönüş tipi parametreleri ne ise 
            // event'a atanacak metodun imzasının da aynı olması gerekir
            //Örn PaintEventHandler içine object tipte bir sender ve PaintEventArgs tipinde e isimli parametreler almış.
            // Bu nedenle button2_Paint isimli metot da aynı imzaya yani aynı geri dönüş tipi ve aynı parametrelere sahip olmalıdır
            //Böylece o delege kendisine constructor'da atanan metodu temsil edebiliyor.
            controlNumberObject.NumberState += new ControlNumber.ControlNumberHandler(Control);
        }

        //Global
        ControlNumber controlNumberObject = new ControlNumber();

        private void btnIsClicked_Paint(object sender, PaintEventArgs e)
        {
            MessageBox.Show("btnIsClicked's paint event is running");
        }

        private void btnIsClicked_CursorOnButton(object sender, EventArgs e)
        {
            btnIsClicked.BackColor = Color.Pink;
        }

        private void btnIsClicked_Click (object sender, EventArgs e)
        {
            MessageBox.Show("Button Clicked");
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            try
            {
                //controlNumberObject.Number = (Convert.ToInt32(textBoxFirstNumber.Text));

                OperationHandler myOperationDelegate = new OperationHandler(Addition);
                myOperationDelegate += Multiplication;
                myOperationDelegate -= Multiplication;
                MessageBox.Show($"Operation: {myOperationDelegate.Method.Name}\nResult = {myOperationDelegate(Convert.ToInt32(textBoxFirstNumber.Text), Convert.ToInt32(textBoxSecondNumber.Text))}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            OperationHandler myOperationDelegate = new OperationHandler(Addition);
            myOperationDelegate += Multiplication;

            Delegate[] myDelegateMethods = myOperationDelegate.GetInvocationList();

            foreach (Delegate item in myDelegateMethods)
            {
                string metotParameterInfo = string.Empty;
                ParameterInfo[] itemParameters = item.Method.GetParameters();
                foreach (var theParameter in itemParameters)
                {
                    metotParameterInfo += $"Parameter Name: {theParameter.Name}\nParameter Type: {theParameter.ParameterType.Name}\n";
                }
                MessageBox.Show($"Running method's name: {item.Method.Name}\nReturn type: {item.Method.ReturnType}\nParameter information\n{metotParameterInfo}\n" +
                    $"Result: {item.DynamicInvoke(Convert.ToInt32(textBoxFirstNumber.Text), Convert.ToInt32(textBoxSecondNumber.Text))}");
            }
        }

        public void Control()
        {
            MessageBox.Show(controlNumberObject.NumberStateMessage);
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            ControlNumber controlNumberObject = new ControlNumber();
            controlNumberObject.NumberState += new ControlNumber.ControlNumberHandler(Control);
            controlNumberObject.Number += Convert.ToInt32(textBoxFirstNumber.Text);
        }

        private void btnPositiveResult_Click(object sender, EventArgs e)
        {
            controlNumberObject.Number = Convert.ToInt32(textBoxFirstNumber.Text);
            if (!controlNumberObject.IsControlNumberSuccess)
            {
                return;
            }

            controlNumberObject.Number = Convert.ToInt32(textBoxSecondNumber.Text);
            if (!controlNumberObject.IsControlNumberSuccess)
            {
                return;
            }

            //if both numbers are greater than or equal to zero, perform following statements.

            OperationHandler myOperation = new OperationHandler(Addition);
            MessageBox.Show($"Result of addition = {myOperation.Invoke(Convert.ToInt32(textBoxFirstNumber.Text), Convert.ToInt32(textBoxSecondNumber.Text))}");
        }
    }
}
