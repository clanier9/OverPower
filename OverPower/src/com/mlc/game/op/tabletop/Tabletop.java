package com.mlc.game.op.tabletop;

import javax.swing.*;

import java.awt.*;


public class Tabletop extends JPanel {	

	public Tabletop() {
		setLayout(new GridBagLayout());
		GridBagConstraints gbc = new GridBagConstraints();
		
		JPanel ocp = new OppCharsPanel();
		gbc.fill = GridBagConstraints.BOTH;
		gbc.anchor = GridBagConstraints.PAGE_START;
		gbc.gridx = 0;
		gbc.gridy = 0;
		gbc.gridwidth = 3;
		gbc.gridheight = 4;
		gbc.weightx = 3;
		gbc.weighty = 4;
		add(ocp, gbc);
//		add(new ChatPanel(), BorderLayout.SOUTH);
	}
	
}
