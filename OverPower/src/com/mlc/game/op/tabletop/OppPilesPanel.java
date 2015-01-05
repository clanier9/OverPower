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
		gbc.fill = GridBagConstraints.BOTH;
		gbc.anchor = GridBagConstraints.LINE_END;
		gbc.ipadx = 33;
		gbc.ipady = 48;
		gbc.weightx = 1;
		gbc.weighty = 1;
		
		gbc.gridx = 0;
		gbc.gridy = 0;	
		JPanel blankPanel = new JPanel();
		this.add(blankPanel, gbc);
		
		gbc.gridx = 0;
		gbc.gridy = 1;	
		blankPanel = new JPanel();
		this.add(blankPanel, gbc);
		
		gbc.gridx = 0;
		gbc.gridy = 2;	
		JPanel oppDraw = new JPanel();
		oppDraw.setBackground(Color.RED);
		this.add(oppDraw, gbc);
		
		gbc.gridx = 0;
		gbc.gridy = 3;
		JPanel oppPowerPack = new JPanel();
		oppPowerPack.setBackground(Color.RED);
		this.add(oppPowerPack, gbc);
		
		gbc.gridx = 0;
		gbc.gridy = 4;	
		blankPanel = new JPanel();
		this.add(blankPanel, gbc);
		
		gbc.gridx = 0;
		gbc.gridy = 5;	
		blankPanel = new JPanel();
		this.add(blankPanel, gbc);
		
		gbc.insets = new Insets(5, 5, 5, 15);
		
		gbc.gridx = 1;
		gbc.gridy = 2;
		JPanel oppDefeatedChars = new JPanel();
		oppDefeatedChars.setBackground(Color.RED);
		this.add(oppDefeatedChars, gbc);
				
		gbc.gridx = 1;
		gbc.gridy = 3;
		JPanel oppDiscard = new JPanel();
		oppDiscard.setBackground(Color.RED);
		this.add(oppDiscard, gbc);
	}
}
