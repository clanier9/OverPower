package com.mlc.game.op.tabletop;

import javax.swing.*;

import java.awt.*;


public class Tabletop extends JPanel {	
	private JPanel event1 = new JPanel();
	
	
	public Tabletop() {
		setLayout(new GridBagLayout());
		GridBagConstraints gbc = new GridBagConstraints();
		gbc.fill = GridBagConstraints.BOTH;
		gbc.weightx = 0.5;
		gbc.weighty = 0.5;	
		
		gbc.gridx = 0;
		gbc.gridy = 0;
		gbc.gridwidth = 48;
		gbc.gridheight = 33;
		event1.setBackground(Color.red);
		add(event1, gbc);
		
		
//		add(new ChatPanel(), BorderLayout.SOUTH);
	}
	
}
