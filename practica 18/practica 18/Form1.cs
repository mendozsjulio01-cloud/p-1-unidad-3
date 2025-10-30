namespace practica_18
{
    using System;
    using System.Windows.Forms;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement;
    {
      private void Decision_Click(object sender, EventArgs e)
    {
        double lado1, lado2, lado3;

        // Asignar correctamente los valores desde los TextBox
        lado1 = double.Parse(textBox1.Text);
        lado2 = double.Parse(textBox2.Text);
        lado3 = double.Parse(textBox3.Text);

        // Verificar el tipo de tri�ngulo
        if ((lado1 == lado2) && (lado2 == lado3))
            textBox4.Text = "Equil�tero";
        else if ((lado1 == lado2) || (lado1 == lado3) || (lado2 == lado3))
            textBox4.Text = "Is�sceles";
        else
            textBox4.Text = "Escaleno";
    }