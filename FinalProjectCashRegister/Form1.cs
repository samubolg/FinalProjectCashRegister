using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System;
using System.Windows.Forms;
using System.Media;

namespace FinalProjectCashRegister
    //January 22
    //Sam Bolger
    //Attempt to make a replica cash register for McDonald's
{
    public partial class donscashRegister : Form
    {
        //variables for all the different menu items
        double sdrinkCost = 0.40;
        double sdrinkTotal;
        double mdrinkCost = 1.00;
        double mdrinkTotal;
        double ldrinkCost = 1.50;
        double ldrinkTotal;
        double scoffeeCost = 1.49;
        double scoffeeTotal;
        double mcoffeeCost = 1.79;
        double mcoffeeTotal;
        double lcoffeeCost = 1.99;
        double lcoffeeTotal;
        double sshakeCost = 2.94;
        double sshakeTotal;
        double mshakeCost = 3.44;
        double mshakeTotal;
        double lshakeCost = 4.04;
        double lshakeTotal;
        double sfriesCost = 1.69;
        double sfriesTotal;
        double mfriesCost = 2.89;
        double mfriesTotal;
        double lfriesCost = 3.29;
        double lfriesTotal;
        double bigmacCost = 5.69;
        double bigmacTotal;
        double quartcheeseCost = 5.69;
        double quartcheeseTotal;
        double quartbltCost = 6.09;
        double quartbltTotal;
        double doubbigmacCost = 7.19;
        double doubbigmacTotal;
        double doubquartcheeseCost = 7.19;
        double doubquartcheeseTotal;
        double doubquartbltCost = 7.49;
        double doubquartbltTotal;
        double filetCost = 5.19;
        double filetTotal;
        double jrchickCost = 1.99;
        double jrchickTotal;
        double mcchickCost = 5.39;
        double mcchickTotal;
        double sixpcCost = 5.59;
        double sixpcTotal;
        double tenpcCost = 6.99;
        double tenpcTotal;
        double twentypcCost = 10.29;
        double twentypcTotal;

        //variables for the different money totals
        double subtotalTotal = 0;
        double taxTotal = 0;
        double taxRate = 0.13;
        double orderTotal = 0;
        double tenderedTotal = 0;
        double changeTotal = 0;
        double tenderedAmount;
        double dailyTotal;

        public donscashRegister()
        {
            InitializeComponent();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            //to print the receipt and have everything come up in the correct order
            SoundPlayer player = new SoundPlayer(Properties.Resources.receiptSound);

            player.Play();
            receiptLabel.Text = "MCDONALD'S CANADA";
            Thread.Sleep(100);
            Refresh();
            receiptLabel.Text += $"\nOrder Number: 1477";
            Thread.Sleep(100);
            Refresh();
            receiptLabel.Text += $"\nJANUARY 23 2021";
            receiptLabel.Text += $"\n";
            Thread.Sleep(100);
            Refresh();
            if (sdrinkTotal > 0)
            {
                receiptLabel.Text += $"\nSMALL DRINK                   x{sdrinkTotal} @ {sdrinkCost.ToString("C")}";
                Thread.Sleep(100);
                Refresh();
            }
            if (mdrinkTotal > 0)
            {
                receiptLabel.Text += $"\nMEDIUM DRINK                  x{mdrinkTotal} @ {mdrinkCost.ToString("C")}";
                Thread.Sleep(100);
                Refresh();
            }
            if (ldrinkTotal > 0)
            {
                receiptLabel.Text += $"\nLARGE DRINK                   x{ldrinkTotal} @ {ldrinkCost.ToString("C")}";
                Thread.Sleep(100);
                Refresh();
            }
            if (scoffeeTotal > 0)
            {
                receiptLabel.Text += $"\nSMALL COFFEE                  x{scoffeeTotal} @ {scoffeeCost.ToString("C")}";
                Thread.Sleep(100);
                Refresh();
            }
            if (mcoffeeTotal > 0)
            {
                receiptLabel.Text += $"\nMEDIUM COFFEE                 x{mcoffeeTotal} @ {mcoffeeCost.ToString("C")}";
                Thread.Sleep(100);
                Refresh();
            }
            if (lcoffeeTotal > 0)
            {
                receiptLabel.Text += $"\nLARGE COFFEE                  x{lcoffeeTotal} @ {lcoffeeCost.ToString("C")}";
                Thread.Sleep(100);
                Refresh();
            }
            if (sshakeTotal > 0)
            {
                receiptLabel.Text += $"\nSMALL SHAKE                   x{sshakeTotal} @ {sshakeCost.ToString("C")}";
                Thread.Sleep(100);
                Refresh();
            }
            if (mshakeTotal > 0)
            {
                receiptLabel.Text += $"\nMEDIUM SHAKE                  x{mshakeTotal} @ {mshakeCost.ToString("C")}";
                Thread.Sleep(100);
                Refresh();
            }
            if (lshakeTotal > 0)
            {
                receiptLabel.Text += $"\nLARGE SHAKE                   x{lshakeTotal} @ {lshakeCost.ToString("C")}";
                Thread.Sleep(100);
                Refresh();
            }
            if (sfriesTotal > 0)
            {
                receiptLabel.Text += $"\nSMALL FRIES                   x{sfriesTotal} @ {sfriesTotal.ToString("C")}";
                Thread.Sleep(100);
                Refresh();
            }
            if (mfriesTotal > 0)
            {
                receiptLabel.Text += $"\nMEDIUM FRIES                  x{mfriesTotal} @ {mfriesTotal.ToString("C")}";
                Thread.Sleep(100);
                Refresh();
            }
            if (lfriesTotal > 0)
            {
                receiptLabel.Text += $"\nLARGE FRIES                   x{lfriesTotal} @ {lfriesTotal.ToString("C")}";
                Thread.Sleep(100);
                Refresh();
            }
            if (bigmacTotal > 0)
            {
                receiptLabel.Text += $"\nBIG MAC                       x{bigmacTotal} @ {bigmacCost.ToString("C")}";
                Thread.Sleep(100);
                Refresh();
            }
            if (quartcheeseTotal > 0)
            {
                receiptLabel.Text += $"\n1/4 POUNDER w/ CHEESE         x{quartcheeseTotal} @ {quartcheeseCost.ToString("C")}";
                Thread.Sleep(100);
                Refresh();
            }
            if (quartbltTotal > 0)
            {
                receiptLabel.Text += $"\n1/4 POUNDER BLT               x{quartbltTotal} @ {quartbltCost.ToString("C")}";
                Thread.Sleep(100);
                Refresh();
            }
            if (doubbigmacTotal > 0)
            {
                receiptLabel.Text += $"\nDOUBLE BIG MAC                x{doubbigmacTotal} @ {doubbigmacCost.ToString("C")}";
                Thread.Sleep(100);
                Refresh();
            }
            if (doubquartcheeseTotal > 0)
            {
                receiptLabel.Text += $"\nDOUBLE 1/4 POUNDER w/ CHEESE  x{doubquartcheeseTotal} @ {doubquartcheeseCost.ToString("C")}";
                Thread.Sleep(100);
                Refresh();
            }
            if (doubquartbltTotal > 0)
            {
                receiptLabel.Text += $"\nDOUBLE 1/4 POUNDER BLT        x{doubquartbltTotal} @ {doubquartbltCost.ToString("C")}";
                Thread.Sleep(100);
                Refresh();
            }
            if (filetTotal > 0)
            {
                receiptLabel.Text += $"\nFILET-O-FISH                  x{filetTotal} @ {filetCost.ToString("C")}";
                Thread.Sleep(100);
                Refresh();
            }
            if (jrchickTotal > 0)
            {
                receiptLabel.Text += $"\nJUNIOR CHICKEN                x{jrchickTotal} @ {jrchickCost.ToString("C")}";
                Thread.Sleep(100);
                Refresh();
            }
            if (mcchickTotal > 0)
            {
                receiptLabel.Text += $"\nMCCHCIKEN                     x{mcchickTotal} @ {mcchickCost.ToString("C")}";
                Thread.Sleep(100);
                Refresh();
            }
            if (sixpcTotal > 0)
            {
                receiptLabel.Text += $"\n6 PIECE CHICKEN MCNUGGETS     x{sixpcTotal} @ {sixpcCost.ToString("C")}";
                Thread.Sleep(100);
                Refresh();
            }
            if (tenpcTotal > 0)
            {
                receiptLabel.Text += $"\n10 PIECE CHICKEN MCNUGGETS    x{tenpcTotal} @ {tenpcCost.ToString("C")}";
                Thread.Sleep(100);
                Refresh();
            }
            if (twentypcTotal > 0)
            {
                receiptLabel.Text += $"\n20 PIECE CHICKEN MCNUGGETS    x{twentypcTotal} @ {twentypcCost.ToString("C")}";
                Thread.Sleep(100);
                Refresh();
            }
            receiptLabel.Text += $"\n";
                receiptLabel.Text += $"\nSubtotal                   {subtotalTotal.ToString("C")}";
                Thread.Sleep(100);
                Refresh();
                receiptLabel.Text += $"\nTax                        {taxTotal.ToString("C")}";
                Thread.Sleep(100);
                Refresh();
                receiptLabel.Text += $"\nTotal                      {orderTotal.ToString("C")}";
                receiptLabel.Text += $"\n";
                Thread.Sleep(100);
                Refresh();
                receiptLabel.Text += $"\nTendered                   {tenderedTotal.ToString("C")}";
                Thread.Sleep(100);
                Refresh();
                receiptLabel.Text += $"\nChange                     {changeTotal.ToString("C")}";
                receiptLabel.Text += $"\n";
                Thread.Sleep(100);
                Refresh();
                receiptLabel.Text += $"\nTHANK YOU FOR CHOOSING MCDONALD'S!";
                Thread.Sleep(100);
                Refresh();
                receiptLabel.Text += $"\nHAVE A WONDERFUL DAY!";
                receiptLabel.Text += "\n";
                Thread.Sleep(100);
                Refresh();
                receiptLabel.Text += $"\nSEE OUR WEBSITE FOR GREAT DEALS!";
                Thread.Sleep(100);
                Refresh();
                receiptLabel.Text += $"\nhttps://www.mcdonalds.com/ca/en-ca";
                Thread.Sleep(100);
                Refresh();
                receiptLabel.Text += $"\nPLEASE COMPLETE OUR SURVEY TO MAKE YOUR EXPERIENCE THE BEST IT CAN BE!";
                Refresh();
        }

        private void totalButton_Click(object sender, EventArgs e)
        {
                //all the calculations to get the totals and add the items together with taxes
                double drinkTotal = sdrinkTotal * sdrinkCost + mdrinkTotal * mdrinkCost + ldrinkTotal * ldrinkCost;
                double coffeeTotal = scoffeeTotal * scoffeeCost + mcoffeeTotal * mcoffeeCost + lcoffeeTotal * lcoffeeCost;
                double shakeTotal = sshakeTotal * sshakeCost + mshakeTotal * mshakeCost + lshakeTotal * lshakeCost;
                double friesTotal = sfriesTotal * sfriesCost + mfriesTotal * mfriesCost + lfriesTotal * lfriesCost;
                double singburgTotal = bigmacTotal * bigmacCost + quartcheeseTotal * quartcheeseCost + quartbltTotal * quartbltCost + filetTotal * filetCost;
                double doubburgTotal = doubbigmacTotal * doubbigmacCost + doubquartcheeseTotal * doubquartcheeseCost + doubquartbltTotal * doubquartbltCost;
                double chickTotal = jrchickTotal * jrchickCost + mcchickTotal * mcchickCost + sixpcTotal * sixpcCost + tenpcTotal * tenpcCost + twentypcTotal * twentypcCost;
                subtotalTotal = coffeeTotal + drinkTotal + shakeTotal + friesTotal + singburgTotal + doubburgTotal + chickTotal;
                taxTotal = subtotalTotal * taxRate;
                orderTotal = subtotalTotal + taxTotal;
                totalLabel.Text = "Total:   " + (orderTotal.ToString("C"));
                taxLabel.Text = "Tax:     " + (taxTotal.ToString("C"));
                subtotalLabel.Text = "Subtotal:" + (subtotalTotal.ToString("C"));
        }

            private void changeButton_Click(object sender, EventArgs e)
            {
                //to calculate the amount of change to give back to the customer
                try
                {
                    printButton.Enabled = true;
                    tenderedTotal = Convert.ToDouble(tenderedTextbox.Text);
                    changeTotal = tenderedTotal - orderTotal;
                    changeLabel.Text = "Change:  " + (changeTotal.ToString("C"));
                    noNumbersLabel.Text = "";
                }
                //to make sure there is a number in the tendered box and not letters
                catch
                {
                    noNumbersLabel.Text = "Please Enter a Numerical Value!";
                }
                SoundPlayer player = new SoundPlayer(Properties.Resources.registerSound);

                player.Play();
            }

            private void newOrderButton_Click(object sender, EventArgs e)
            {
            //reseting all the values to 0 and wiping all of the labels back to blank
                changeTotal = 0;
                tenderedTotal = 0;
                dailyTotal = dailyTotal + orderTotal;
                orderTotal = 0;
                taxTotal = 0;
                subtotalTotal = 0;
                sdrinkTotal = 0;
                mdrinkTotal = 0;
                ldrinkTotal = 0;
                scoffeeTotal = 0;
                mcoffeeTotal = 0;
                lcoffeeTotal = 0;
                sshakeTotal = 0;
                mshakeTotal = 0;
                lshakeTotal = 0;
                sfriesTotal = 0;
                mfriesTotal = 0;
                lfriesTotal = 0;
                bigmacTotal = 0;
                quartcheeseTotal = 0;
                quartbltTotal = 0;
                doubbigmacTotal = 0;
                doubquartcheeseTotal = 0;
                doubquartbltTotal = 0;
                filetTotal = 0;
                jrchickTotal = 0;
                mcchickTotal = 0;
                sixpcTotal = 0;
                tenpcTotal = 0;
                twentypcTotal = 0;
                changeLabel.Text = "Change:   $0.00";
                tenderedTextbox.Text = "";
                taxLabel.Text = "Tax:      $0.00";
                subtotalLabel.Text = "Subtotal: $0.00";
                totalLabel.Text = "Total:    $0.00";
                receiptLabel.Text = "Order";
                voidButton.BackColor = Color.Gray;
                printButton.Enabled = false;
            }


            //having the buttons be able to add one item to the total and take one away via the void button
            private void sdrinkButton_Click(object sender, EventArgs e)
            {
                if (voidButton.BackColor == Color.Gray)
                {
                    sdrinkTotal += 1;
                }
                else
                {
                    sdrinkTotal -= 1;
                    voidButton.BackColor = Color.Gray;
                }
                orderDisplay();
                SoundPlayer player = new SoundPlayer(Properties.Resources.bellSound);

                player.Play();
            }

            private void mdrinkButton_Click(object sender, EventArgs e)
            {
                if (voidButton.BackColor == Color.Gray)
                {
                    mdrinkTotal += 1;
                }
                else
                {
                    mdrinkTotal -= 1;
                    voidButton.BackColor = Color.Gray;
                }
                orderDisplay();
                SoundPlayer player = new SoundPlayer(Properties.Resources.bellSound);

                player.Play();
            }
            private void ldrinkButton_Click(object sender, EventArgs e)
            {
                if (voidButton.BackColor == Color.Gray)
                {
                    ldrinkTotal += 1;
                }
                else
                {
                    ldrinkTotal -= 1;
                    voidButton.BackColor = Color.Gray;
                }
                orderDisplay();
                SoundPlayer player = new SoundPlayer(Properties.Resources.bellSound);

                player.Play();
            }
            private void scoffeeLabel_Click(object sender, EventArgs e)
            {
                if (voidButton.BackColor == Color.Gray)
                {
                    scoffeeTotal += 1;
                }
                else
                {
                    scoffeeTotal -= 1;
                    voidButton.BackColor = Color.Gray;
                }
                orderDisplay();
                SoundPlayer player = new SoundPlayer(Properties.Resources.bellSound);

                player.Play();
            }
            private void mcoffeeLabel_Click(object sender, EventArgs e)
            {
                if (voidButton.BackColor == Color.Gray)
                {
                    mcoffeeTotal += 1;
                }
                else
                {
                    mcoffeeTotal -= 1;
                    voidButton.BackColor = Color.Gray;
                }
                orderDisplay();
                SoundPlayer player = new SoundPlayer(Properties.Resources.bellSound);

                player.Play();
            }
            private void lcoffeeLabel_Click(object sender, EventArgs e)
            {
                if (voidButton.BackColor == Color.Gray)
                {
                    lcoffeeTotal += 1;
                }
                else
                {
                    lcoffeeTotal -= 1;
                    voidButton.BackColor = Color.Gray;
                }
                orderDisplay();
                SoundPlayer player = new SoundPlayer(Properties.Resources.bellSound);

                player.Play();
            }
            private void sshakeButton_Click(object sender, EventArgs e)
            {
                if (voidButton.BackColor == Color.Gray)
                {
                    sshakeTotal += 1;
                }
                else
                {
                    sshakeTotal -= 1;
                    voidButton.BackColor = Color.Gray;
                }
                orderDisplay();
                SoundPlayer player = new SoundPlayer(Properties.Resources.bellSound);

                player.Play();
            }
            private void mshakeButton_Click(object sender, EventArgs e)
            {
                if (voidButton.BackColor == Color.Gray)
                {
                    mshakeTotal += 1;
                }
                else
                {
                    mshakeTotal -= 1;
                    voidButton.BackColor = Color.Gray;
                }
                orderDisplay();
                SoundPlayer player = new SoundPlayer(Properties.Resources.bellSound);

                player.Play();
            }
            private void lshakeButton_Click(object sender, EventArgs e)
            {
                if (voidButton.BackColor == Color.Gray)
                {
                    lshakeTotal += 1;
                }
                else
                {
                    lshakeTotal -= 1;
                    voidButton.BackColor = Color.Gray;
                }
                orderDisplay();
                SoundPlayer player = new SoundPlayer(Properties.Resources.bellSound);

                player.Play();
            }
            private void sfriesButton_Click(object sender, EventArgs e)
            {
                if (voidButton.BackColor == Color.Gray)
                {
                    sfriesTotal += 1;
                }
                else
                {
                    sfriesTotal -= 1;
                    voidButton.BackColor = Color.Gray;
                }
                orderDisplay();
                SoundPlayer player = new SoundPlayer(Properties.Resources.bellSound);

                player.Play();
            }
            private void mfriesButton_Click(object sender, EventArgs e)
            {
                if (voidButton.BackColor == Color.Gray)
                {
                    mfriesTotal += 1;
                }
                else
                {
                    mfriesTotal -= 1;
                    voidButton.BackColor = Color.Gray;
                }
                orderDisplay();
                SoundPlayer player = new SoundPlayer(Properties.Resources.bellSound);

                player.Play();
            }
            private void lfriesButton_Click(object sender, EventArgs e)
            {
                if (voidButton.BackColor == Color.Gray)
                {
                    lfriesTotal += 1;
                }
                else
                {
                    lfriesTotal -= 1;
                    voidButton.BackColor = Color.Gray;
                }
                orderDisplay();
                SoundPlayer player = new SoundPlayer(Properties.Resources.bellSound);

                player.Play();
            }
            private void bigmacButton_Click(object sender, EventArgs e)
            {
                if (voidButton.BackColor == Color.Gray)
                {
                    bigmacTotal += 1;
                }
                else
                {
                    bigmacTotal -= 1;
                    voidButton.BackColor = Color.Gray;
                }
                orderDisplay();
                SoundPlayer player = new SoundPlayer(Properties.Resources.bellSound);

                player.Play();
            }
            private void quartcheeseButton_Click(object sender, EventArgs e)
            {
                if (voidButton.BackColor == Color.Gray)
                {
                    quartcheeseTotal += 1;
                }
                else
                {
                    quartcheeseTotal -= 1;
                    voidButton.BackColor = Color.Gray;
                }
                orderDisplay();
                SoundPlayer player = new SoundPlayer(Properties.Resources.bellSound);

                player.Play();
            }
            private void quartbltButton_Click(object sender, EventArgs e)
            {
                if (voidButton.BackColor == Color.Gray)
                {
                    quartbltTotal += 1;
                }
                else
                {
                    quartbltTotal -= 1;
                    voidButton.BackColor = Color.Gray;
                }
                orderDisplay();
                SoundPlayer player = new SoundPlayer(Properties.Resources.bellSound);

                player.Play();
            }
            private void doubbigmacButton_Click(object sender, EventArgs e)
            {
                if (voidButton.BackColor == Color.Gray)
                {
                    doubbigmacTotal += 1;
                }
                else
                {
                    doubbigmacTotal -= 1;
                    voidButton.BackColor = Color.Gray;
                }
                orderDisplay();
                SoundPlayer player = new SoundPlayer(Properties.Resources.bellSound);

                player.Play();
            }
            private void doubquartcheeseButton_Click(object sender, EventArgs e)
            {
                if (voidButton.BackColor == Color.Gray)
                {
                    doubquartcheeseTotal += 1;
                }
                else
                {
                    doubquartcheeseTotal -= 1;
                    voidButton.BackColor = Color.Gray;
                }
                orderDisplay();
                SoundPlayer player = new SoundPlayer(Properties.Resources.bellSound);

                player.Play();
            }
            private void doubquartbltButton_Click(object sender, EventArgs e)
            {
                if (voidButton.BackColor == Color.Gray)
                {
                    doubquartbltTotal += 1;
                }
                else
                {
                    doubquartbltTotal -= 1;
                    voidButton.BackColor = Color.Gray;
                }
                orderDisplay();
                SoundPlayer player = new SoundPlayer(Properties.Resources.bellSound);

                player.Play();
            }
            private void filetButton_Click(object sender, EventArgs e)
            {
                if (voidButton.BackColor == Color.Gray)
                {
                    filetTotal += 1;
                }
                else
                {
                    filetTotal -= 1;
                    voidButton.BackColor = Color.Gray;
                }
                orderDisplay();
                SoundPlayer player = new SoundPlayer(Properties.Resources.bellSound);

                player.Play();
            }
            private void jrchickButton_Click(object sender, EventArgs e)
            {
                if (voidButton.BackColor == Color.Gray)
                {
                    jrchickTotal += 1;
                }
                else
                {
                    jrchickTotal -= 1;
                    voidButton.BackColor = Color.Gray;
                }
                orderDisplay();
                SoundPlayer player = new SoundPlayer(Properties.Resources.bellSound);

                player.Play();
            }
            private void mcchickButton_Click(object sender, EventArgs e)
            {
            if (voidButton.BackColor == Color.Gray)
            {
                mcchickTotal += 1;
            }
            else
            {
                mcchickTotal -= 1;
                voidButton.BackColor = Color.Gray;
            }
            orderDisplay();
            SoundPlayer player = new SoundPlayer(Properties.Resources.bellSound);

            player.Play();
            }
            private void sixpcButton_Click(object sender, EventArgs e)
            {
            if (voidButton.BackColor == Color.Gray)
            {
                sixpcTotal += 1;
            }
            else
            {
                sixpcTotal -= 1;
                voidButton.BackColor = Color.Gray;
            }
            orderDisplay();
            SoundPlayer player = new SoundPlayer(Properties.Resources.bellSound);

            player.Play();
            }
            private void tenpcButton_Click(object sender, EventArgs e)
            {
            if (voidButton.BackColor == Color.Gray)
            {
                tenpcTotal += 1;
            }
            else
            {
                tenpcTotal -= 1;
                voidButton.BackColor = Color.Gray;
            }
            orderDisplay();
            SoundPlayer player = new SoundPlayer(Properties.Resources.bellSound);

            player.Play();
            }
            private void twentypcButton_Click(object sender, EventArgs e)
            {
                if (voidButton.BackColor == Color.Gray)
                {
                    twentypcTotal += 1;
                }
                else
                {
                    twentypcTotal -= 1;
                    voidButton.BackColor = Color.Gray;
                }
                orderDisplay();
                SoundPlayer player = new SoundPlayer(Properties.Resources.bellSound);

                player.Play();
            }

        //create custom methods here
        public void orderDisplay()
            {
                //making sure the customer can see their order pop up on the receipt label as they order the items
                receiptLabel.Text = "New Order";
                if (sdrinkTotal > 0)
                {
                    receiptLabel.Text += $"\nSmall Drink                  " + (sdrinkTotal);

                }
                if (mdrinkTotal > 0)
                {
                    receiptLabel.Text += $"\nMedium Drink                 " + (mdrinkTotal);

                }
                if (ldrinkTotal > 0)
                {
                    receiptLabel.Text += $"\nLarge Drink                  " + (ldrinkTotal);
                }
                if (scoffeeTotal > 0)
                {
                    receiptLabel.Text += $"\nSmall Coffee                 " + (scoffeeTotal);
                }
                if (mcoffeeTotal > 0)
                {
                    receiptLabel.Text += $"\nMedium Coffee                " + (mcoffeeTotal);
                }
                if (lcoffeeTotal > 0)
                {
                    receiptLabel.Text += $"\nLarge Coffee                 " + (lcoffeeTotal);
                }
                if (sshakeTotal > 0)
                {
                    receiptLabel.Text += $"\nSmall Shake                  " + (sshakeTotal);
                }
                if (mshakeTotal > 0)
                {
                    receiptLabel.Text += $"\nMedium Shake                 " + (mshakeTotal);
                }
                if (lshakeTotal > 0)
                {
                    receiptLabel.Text += $"\nLarge Shake                  " + (lshakeTotal);
                }
                if (sfriesTotal > 0)
                {
                    receiptLabel.Text += $"\nSmall Fries                  " + (sfriesTotal);
                }
                if (mfriesTotal > 0)
                {
                    receiptLabel.Text += $"\nMedium Fries                 " + (mfriesTotal);
                }
                if (lfriesTotal > 0)
                {
                    receiptLabel.Text += $"\nLarge Fries                  " + (lfriesTotal);
                }
                if (bigmacTotal > 0)
                {
                    receiptLabel.Text += $"\nBig Mac                      " + (bigmacTotal);
                }
                if (quartcheeseTotal > 0)
                {
                    receiptLabel.Text += $"\n1/4 Pounder w/ Cheese        " + (quartcheeseTotal);
                }
                if (quartbltTotal > 0)
                {
                    receiptLabel.Text += $"\n1/4 Pounder BLT              " + (quartbltTotal);
                }
                if (doubbigmacTotal > 0)
                {
                    receiptLabel.Text += $"\nDouble Big Mac               " + (doubbigmacTotal);
                }
                if (doubquartcheeseTotal > 0)
                {
                    receiptLabel.Text += $"\nDouble 1/4 Pounder w/ Cheese " + (doubquartcheeseTotal);
                }
                if (doubquartbltTotal > 0)
                {
                    receiptLabel.Text += $"\nDouble 1/4 Pounder BLT       " + (doubquartbltTotal);
                }
                if (filetTotal > 0)
                {
                    receiptLabel.Text += $"\nFilet-O-Fish                 " + (filetTotal);
                }
                if (jrchickTotal > 0)
                {
                    receiptLabel.Text += $"\nJunior Chicken               " + (jrchickTotal);
                }
                if (mcchickTotal > 0)
                {
                    receiptLabel.Text += $"\nMcChicken                    " + (mcchickTotal);
                }
                if (sixpcTotal > 0)
                {
                    receiptLabel.Text += $"\n6 Piece Chicken McNuggets    " + (sixpcTotal);
                }
                if (tenpcTotal > 0)
                {
                    receiptLabel.Text += $"\n10 Piece Chicken McNuggets   " + (tenpcTotal);
                }
                if (twentypcTotal > 0)
                {
                    receiptLabel.Text += $"\n20 Piece Chicken McNuggets   " + (twentypcTotal);
                }
        }

            private void voidButton_Click(object sender, EventArgs e)
            {
                //having the void buttons change colour to make sure the items get taken off the order when the void button is red
                if (voidButton.BackColor == Color.Gray)
                {
                    voidButton.BackColor = Color.Red;
                }
                else
                {
                    voidButton.BackColor = Color.Gray;
                }
            }

        private void dailytotalButton_Click(object sender, EventArgs e)
        {
            receiptLabel.Text = "";
            receiptLabel.Text = "Daily Total";
            receiptLabel.Text += "\n= " +(dailyTotal.ToString("C"));
        }
    }
}
