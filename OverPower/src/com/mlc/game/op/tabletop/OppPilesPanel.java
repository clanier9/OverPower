package com.mlc.game.op.tabletop;

import java.awt.Color;
import java.awt.GridBagConstraints;
import java.awt.GridBagLayout;
import java.awt.Insets;

import javax.swing.JPanel;

public class OppPilesPanel extends JPanel {
	public OppPilesPanel() {
		this.setLayout(new GridBagLayout());
		GridBagConstraints gbc = new GridBagConstraints();
		gbc.insets = new Insets(5, 15, 5, 5);
		
		gbc.gridx = 0;
		gbc.gridy = 0;	
		JPanel oppDraw = new JPanel();
		oppDraw.setBackground(Color.RED);
		this.add(oppDraw, gbc);
		
		gbc.gridx = 0;
		gbc.gridy = 1;
		JPanel oppPowerPack = new JPanel();
		oppPowerPack.setBackground(Color.RED);
		this.add(oppPowerPack, gbc);
		
		gbc.insets = new Insets(5, 5, 5, 15);
		
		gbc.gridx = 1;
		gbc.gridy = 0;
		JPanel oppDefeatedChars = new JPanel();
		oppDefeatedChars.setBackground(Color.RED);
		this.add(oppDefeatedChars, gbc);
				
		gbc.gridx = 1;
		gbc.gridy = 1;
		JPanel oppDiscard = new JPanel();
		oppDiscard.setBackground(Color.RED);
		this.add(oppDiscard, gbc);
	}
}
