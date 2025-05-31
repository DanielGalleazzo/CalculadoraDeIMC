import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class Interface {
    JFrame tela = new JFrame("Calculadora de IMC");
    JPanel panel = new JPanel();
    JLabel nomeLBL = new JLabel("Nome do usuário: ");
    JTextField nomeTXT = new JTextField(20);
    JLabel idadeLBL = new JLabel("Idade do usúario");
    JTextField idadeTXT = new JTextField(20);
    JLabel PesoLBL = new JLabel("Insira o peso do usuário");
    JTextField pesoTXT = new JTextField(20);
    JLabel AlturaLBL = new JLabel("Insira a altura do usuário");
    JTextField AlturaTXT = new JTextField(20);
    JButton Calcular = new JButton("Calcular IMC");
    JLabel IMC = new JLabel("O imc é de:");

    public Interface() {
        panel.add(nomeLBL);
        panel.add(nomeTXT);
        panel.add(idadeLBL);
        panel.add(idadeTXT);
        panel.add(PesoLBL);
        panel.add(pesoTXT);
        panel.add(AlturaLBL);
        panel.add(AlturaTXT);
        panel.add(Calcular);
        panel.add(IMC);
        tela.add(panel);
        tela.pack();
        tela.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        tela.setVisible(true);
        Calcular.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                double peso = Double.parseDouble(pesoTXT.getText().replace(",", "."));
                double altura = Double.parseDouble(AlturaTXT.getText().replace(",", "."));
                double imc = peso / (altura * altura);
                IMC.setText("IMC = " + imc);
            }
        });
    }
}