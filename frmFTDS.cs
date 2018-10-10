using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace FTDS
{
    public partial class frmFTDS : Form
    {
        public frmFTDS()
        {
            InitializeComponent();
        }

        private void Math_Tick(object sender, EventArgs e)
        {
            //Beans
            nClassicUsed.Value = nClassicStart.Value - nClassicFinish.Value;
            nDarkUsed.Value = nDarkStart.Value - nDarkFinish.Value;
            nDecafUsed.Value = nDecafStart.Value - nDecafFinish.Value;

            nBeanTotal.Value = nClassicUsed.Value + nDarkUsed.Value + nDecafUsed.Value;


            //Milk
            nMilkUsed.Value = nMilkStart.Value - nMilkFinish.Value;
            nSoyUsed.Value = nSoyStart.Value - nSoyFinish.Value;

            nMilkTotal.Value = nMilkUsed.Value + nSoyUsed.Value;


            //Cups
            n4ozUsed.Value = n4ozStart.Value - n4ozFinish.Value;
            n8ozUsed.Value = n8ozStart.Value - n8ozFinish.Value;
            n14ozUsed.Value = n14ozStart.Value - n14ozFinish.Value;

            nCupTotal.Value = n4ozUsed.Value + n8ozUsed.Value + n14ozUsed.Value;

            n4ozTotal.Value = n4ozUsed.Value - n4ozNon.Value;
            n8ozTotal.Value = n8ozUsed.Value - n8ozNon.Value;
            n14ozTotal.Value = n14ozUsed.Value - n14ozNon.Value;

            nCupsTotal.Value = n4ozTotal.Value + n8ozTotal.Value + n14ozTotal.Value;

            n4ozSales.Value = n4ozTotal.Value * 3;
            n8ozSales.Value = n8ozTotal.Value * 4;
            n14ozSales.Value = n14ozTotal.Value * 5.5m;

            nCupSalesTotal.Value = n4ozSales.Value + n8ozSales.Value + n14ozSales.Value;


            //Consumption
            if (nBeanTotal.Value !=0)
            nConsumptionBeans.Value = nCupTotal.Value / nBeanTotal.Value;

            if (nMilkTotal.Value !=0)
            nConsumptionMilk.Value = nCupTotal.Value / nMilkTotal.Value;


            //Sales
            nSalesCups.Value = nCupSalesTotal.Value;
            nSalesSoy.Value = nSoyUsed.Value * 2;

            nSalesFood.Value = nFridgeFoodTotal.Value + nBakingTotal.Value;

            nSalesDrinks.Value = nAppleSales.Value + nPeachSales.Value + nOrangeSales.Value + nFeijoaSales.Value + nKiwifruitSales.Value + nWildBerrySales.Value + nStill500Sales.Value + nSpark500Sales.Value + nStill350Sales.Value;

            nSalesRetail.Value = nClassicRetailSales.Value + nDarkRetailSales.Value + nDecafRetailSales.Value + nCocoaRetailSales.Value + nSingleOriginRetailSales.Value;

            nSalesTotal.Value = nSalesCups.Value + nSalesDrinks.Value + nSalesFood.Value + nSalesRetail.Value + nSalesSoy.Value - nSalesPrePaid.Value;


            //Cash
            n100.Value = n100Amount.Value * 100;
            n50.Value = n50Amount.Value * 50;
            n20.Value = n20Amount.Value * 20;
            n10.Value = n10Amount.Value * 10;
            n5.Value = n5Amount.Value * 5;

            n2.Value = n2Amount.Value * 2;
            n1.Value = n1Amount.Value * 1;
            n50c.Value = n50cAmount.Value * 0.5m;
            n20c.Value = n20cAmount.Value * 0.2m;
            n10c.Value = n10cAmount.Value * 0.1m;

            nTotalNotes.Value = n100.Value + n50.Value + n20.Value + n10.Value + n5.Value;

            nTotalCoins.Value = n2.Value + n1.Value + n50c.Value + n20c.Value + n10c.Value;

            nTotalCash.Value = nTotalNotes.Value + nTotalCoins.Value;

            nDaysTake.Value = nTotalCash.Value - nFloatAmount.Value + nPlusEftpos.Value;

            nLessFloat.Value = nTotalCash.Value - nFloatAmount.Value;
            nTillOffset.Value = nDaysTake.Value - nSalesTotal.Value;


            //Food

            //Baking
            nSconeUsed.Value = nSconeStart.Value - nSconeFinish.Value;
            nSconeTotals.Value = nSconeUsed.Value - nSconeReturns.Value;
            nSconeSales.Value = nSconeTotals.Value * 4;

            nMuffinUsed.Value = nMuffinStart.Value - nMuffinFinish.Value;
            nMuffinTotals.Value = nMuffinUsed.Value - nMuffinReturns.Value;
            nMuffinSales.Value = nMuffinTotals.Value * 4;

            nGingerUsed.Value = nGingerStart.Value - nGingerFinish.Value;
            nGingerTotals.Value = nGingerUsed.Value - nGingerReturns.Value;
            nGingerSales.Value = nGingerTotals.Value * 4;

            nCaramelUsed.Value = nCaramelStart.Value - nCaramelFinish.Value;
            nCaramelTotals.Value = nCaramelUsed.Value - nCaramelReturns.Value;
            nCaramelSales.Value = nCaramelTotals.Value * 4;

            nBrownieUsed.Value = nBrownieStart.Value - nBrownieFinish.Value;
            nBrownieTotals.Value = nBrownieUsed.Value - nBrownieReturns.Value;
            nBrownieSales.Value = nBrownieTotals.Value * 4;

            nPeanutUsed.Value = nPeanutStart.Value - nPeanutFinish.Value;
            nPeanutTotals.Value = nPeanutUsed.Value - nPeanutReturns.Value;
            nPeanutSales.Value = nPeanutTotals.Value * 3;

            nAnzacUsed.Value = nAnzacStart.Value - nAnzacFinish.Value;
            nAnzacTotals.Value = nAnzacUsed.Value - nAnzacReturns.Value;
            nAnzacSales.Value = nAnzacTotals.Value * 3;

            nFriandUsed.Value = nFriandStart.Value - nFriandFinish.Value;
            nFriandTotals.Value = nFriandUsed.Value - nFriandReturns.Value;
            nFriandSales.Value = nFriandTotals.Value * 4.5m;

            nBakingTotal.Value = nSconeSales.Value + nMuffinSales.Value + nGingerSales.Value + nCaramelSales.Value + nBrownieSales.Value + nPeanutSales.Value + nAnzacSales.Value + nFriandSales.Value;
            

            //Fridge
            nChickenUsed.Value = nChickenStart.Value - nChickenFinish.Value;
            nChickenTotals.Value = nChickenUsed.Value - nChickenReturns.Value;
            nChickenSales.Value = nChickenTotals.Value * 6.5m;

            nHamUsed.Value = nHamStart.Value - nHamFinish.Value;
            nHamTotals.Value = nHamUsed.Value - nHamReturns.Value;
            nHamSales.Value = nHamTotals.Value * 6.5m;

            nPastaUsed.Value = nPastaStart.Value - nPastaFinish.Value;
            nPastaTotals.Value = nPastaUsed.Value - nPastaReturns.Value;
            nPastaSales.Value = nPastaTotals.Value * 8;

            nQuinoaUsed.Value = nQuinoaStart.Value - nQuinoaFinish.Value;
            nQuinoaTotals.Value = nQuinoaUsed.Value - nQuinoaReturns.Value;
            nQuinoaSales.Value = nQuinoaTotals.Value * 8;

            nCornUsed.Value = nCornStart.Value - nCornFinish.Value;
            nCornTotals.Value = nCornUsed.Value - nCornReturns.Value;
            nCornSales.Value = nCornTotals.Value * 8;

            nIsraeliUsed.Value = nIsraeliStart.Value - nIsraeliFinish.Value;
            nIsraeliTotals.Value = nIsraeliUsed.Value - nIsraeliReturns.Value;
            nIsraeliSales.Value = nIsraeliTotals.Value * 8;

            nTaboulehUsed.Value = nTaboulehStart.Value - nTaboulehFinish.Value;
            nTaboulehTotals.Value = nTaboulehUsed.Value - nTaboulehReturns.Value;
            nTaboulehSales.Value = nTaboulehTotals.Value * 8;

            nFridgeFoodTotal.Value = nChickenSales.Value + nHamSales.Value + nPastaSales.Value + nQuinoaSales.Value + nCornSales.Value + nIsraeliSales.Value + nTaboulehSales.Value;


            //Drinks
            nAppleSold.Value = nAppleStart.Value - nAppleFinish.Value;
            nAppleSales.Value = nAppleSold.Value * 4;

            nPeachSold.Value = nPeachStart.Value - nPeachFinish.Value;
            nPeachSales.Value = nPeachSold.Value * 4;

            nOrangeSold.Value = nOrangeStart.Value - nOrangeFinish.Value;
            nOrangeSales.Value = nOrangeSold.Value * 4;

            nFeijoaSold.Value = nFeijoaStart.Value - nFeijoaFinish.Value;
            nFeijoaSales.Value = nFeijoaSold.Value * 4;

            nKiwifruitSold.Value = nKiwifruitStart.Value - nKiwifruitFinish.Value;
            nKiwifruitSales.Value = nKiwifruitSold.Value * 4;

            nWildBerrySold.Value = nWildBerryStart.Value - nWildBerryFinish.Value;
            nWildBerrySales.Value = nWildBerrySold.Value * 4;

            nStill500Sold.Value = nStill500Start.Value - nStill500Finish.Value;
            nStill500Sales.Value = nStill500Sold.Value * 4;

            nSpark500Sold.Value = nSpark500Start.Value - nSpark500Finish.Value;
            nSpark500Sales.Value = nSpark500Sold.Value * 4;

            nStill350Sold.Value = nStill350Start.Value - nStill350Finish.Value;
            nStill350Sales.Value = nStill350Sold.Value * 3;


            //Retail
            nClassicRetailSales.Value = (nClassicRetailStart.Value - nClassicRetailFinish.Value) * 12;

            nDarkRetailSales.Value = (nDarkRetailStart.Value - nDarkRetailFinish.Value) * 12;

            nDecafRetailSales.Value = (nDecafRetailStart.Value - nDecafRetailFinish.Value) * 15;

            nCocoaRetailSales.Value = (nCocoaRetailStart.Value - nCocoaRetailFinish.Value) * 15;

            nSingleOriginRetailSales.Value = (nSingleOriginRetailStart.Value - nSingleOriginRetailFinish.Value) * 15;

            //Other
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Microsoft.VisualBasic.Interaction.InputBox("Title", "Prompt", "Default", 0, 0);

        }

        private void btnBeansInput_Click(object sender, EventArgs e)
        {
            //Populate Bean Values with Dialog Boxes
            nClassicStart.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Classic Start", "Bean Count", "0", 0, 0));
            nClassicFinish.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Classic Finish", "Bean Count", "0", 0, 0));

            nDarkStart.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Dark Start", "Bean Count", "0", 0, 0));
            nDarkFinish.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Dark Finish", "Bean Count", "0", 0, 08));

            nDecafStart.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Decaf Start", "Bean Count", "0", 0, 0));
            nDecafFinish.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Decaf Finish", "Bean Count", "0", 0, 0));
        }

        private void btnCupsInput_Click(object sender, EventArgs e)
        {
            n4ozStart.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("4oz Start", "Cup Count", "0", 0, 0));
            n4ozFinish.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("4oz Finish", "Cup Count", "0", 0, 0));

            n8ozStart.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("8oz Start", "Cup Count", "0", 0, 0));
            n8ozFinish.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("8oz Finish", "Cup Count", "0", 0, 0));

            n14ozStart.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("14oz Start", "Cup Count", "0", 0, 0));
            n14ozFinish.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("14oz Finish", "Cup Count", "0", 0, 0));
        }

        private void btnBakingInput_Click(object sender, EventArgs e)
        {
            nSconeStart.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Scone Start", "Baking", "0", 0, 0));
            nSconeFinish.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Scone Finish", "Baking", "0", 0, 0));

            nMuffinStart.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Muffin Start", "Baking", "0", 0, 0));
            nMuffinFinish.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Muffin Finish", "Baking", "0", 0, 0));

            nGingerStart.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ginger Start", "Baking", "0", 0, 0));
            nGingerFinish.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ginger Finish", "Baking", "0", 0, 0));

            nCaramelStart.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Caramel Start", "Baking", "0", 0, 0));
            nCaramelFinish.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Caramel Finish", "Baking", "0", 0, 0));

            nBrownieStart.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Brownie Start", "Baking", "0", 0, 0));
            nBrownieFinish.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Brownie Finish", "Baking", "0", 0, 0));

            nAnzacStart.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Anzac Start", "Baking", "0", 0, 0));
            nAnzacFinish.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Anzac Finish", "Baking", "0", 0, 0));

            nPeanutStart.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Peanut Start", "Baking", "0", 0, 0));
            nPeanutFinish.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Peanut Finish", "Baking", "0", 0, 0));

            nFriandStart.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Friand Start", "Baking", "0", 0, 0));
            nFriandFinish.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Friand Finish", "Baking", "0", 0, 0));

        }

        private void btnFridgeInput_Click(object sender, EventArgs e)
        {
            nChickenStart.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Chicken Start", "Fridge Food", "0", 0, 0));
            nChickenFinish.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Chicken Finish", "Fridge Food", "0", 0, 0));

            nHamStart.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ham Start", "Fridge Food", "0", 0, 0));
            nHamFinish.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ham Finish", "Fridge Food", "0", 0, 0));

            nPastaStart.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Pasta Start", "Fridge Food", "0", 0, 0));
            nPastaFinish.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Pasta Finish", "Fridge Food", "0", 0, 0));

            nQuinoaStart.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Quinoa Start", "Fridge Food", "0", 0, 0));
            nQuinoaFinish.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Quinoa Finish", "Fridge Food", "0", 0, 0));

            nCornStart.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Corn Start", "Fridge Food", "0", 0, 0));
            nCornFinish.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Corn Finish", "Fridge Food", "0", 0, 0));

            nIsraeliStart.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Israeli Start", "Fridge Food", "0", 0, 0));
            nIsraeliFinish.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Israeli Finish", "Fridge Food", "0", 0, 0));

            nTaboulehStart.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Tabouleh Start", "Fridge Food", "0", 0, 0));
            nTaboulehFinish.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Tabouleh Finish", "Fridge Food", "0", 0, 0));
        }

        private void btnDrinksInput_Click(object sender, EventArgs e)
        {
            nAppleStart.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Apple Start", "Drinks", "0", 0, 0));
            nAppleFinish.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Apple Finish", "Drinks", "0", 0, 0));

            nPeachStart.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Peach Start", "Drinks", "0", 0, 0));
            nPeachFinish.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Peach Finish", "Drinks", "0", 0, 0));

            nOrangeStart.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Orange Start", "Drinks", "0", 0, 0));
            nOrangeFinish.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Orange Finish", "Drinks", "0", 0, 0));

            nFeijoaStart.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Feijoa Start", "Drinks", "0", 0, 0));
            nFeijoaFinish.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Feijoa Finish", "Drinks", "0", 0, 0));

            nKiwifruitStart.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Kiwifruit Start", "Drinks", "0", 0, 0));
            nKiwifruitFinish.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Kiwifruit Finish", "Drinks", "0", 0, 0));

            nWildBerryStart.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("WildBerry Start", "Drinks", "0", 0, 0));
            nWildBerryFinish.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("WildBerry Finish", "Drinks", "0", 0, 0));

            nStill500Start.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Still500 Start", "Drinks", "0", 0, 0));
            nStill500Finish.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Still500 Finish", "Drinks", "0", 0, 0));

            nSpark500Start.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Spark500 Start", "Drinks", "0", 0, 0));
            nSpark500Finish.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Spark500 Finish", "Drinks", "0", 0, 0));

            nStill350Start.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Still350 Start", "Drinks", "0", 0, 0));
            nStill350Finish.Value = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Still350 Finish", "Drinks", "0", 0, 0));
        }

        private void btnMilkOrderInput_Click(object sender, EventArgs e)
        {
            decimal BlueMilk = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Current Blue Milk Bottles", "Milk Order", "0", 0, 0));
            decimal TrimMilk = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Current Trim Milk Bottles", "Milk Order", "0", 0, 0));

            decimal BlueMilkNeeded = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Blue Milk Bottles Needed at Days Start", "Milk Order", "0", 0, 0));
            decimal TrimMilkNeeded = Decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Trim Milk Bottles Needed at Days Start", "Milk Order", "0", 0, 0));


            String BlueMilkOrder = (BlueMilkNeeded - BlueMilk).ToString();
            String TrimMilkOrder = (TrimMilkNeeded - TrimMilk).ToString();

            MessageBox.Show("You should order " + BlueMilkOrder + " blue bottles " + "and " + TrimMilkOrder + " trim bottles.");
        }
    }
}
