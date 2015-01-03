package com.mlc.game.op.tabletop;

import java.awt.Color;
import java.awt.GridBagConstraints;
import java.awt.GridBagLayout;
import java.awt.Insets;

import javax.swing.JPanel;

public class OppCharsPanel extends JPanel {
	public OppCharsPanel() {
		setLayout(new GridBagLayout());
		GridBagConstraints gbc = new GridBagConstraints();
		gbc.insets = new Insets(20, 15, 20, 15);
		gbc.fill = GridBagConstraints.BOTH;
		gbc.gridwidth = 4;
		gbc.gridheight = 3;
		gbc.weightx = 4.0;
		gbc.weighty = 3.0;
		
		//back row
		gbc.gridx = 0;
		gbc.gridy = 0;
		JPanel blankPanel = new JPanel();
		this.add(blankPanel, gbc);
		
		gbc.gridx = 4;
		gbc.gridy = 0;
		JPanel oppHomebase = new JPanel();
		oppHomebase.setBackground(Color.RED);
		this.add(oppHomebase, gbc);
		
		gbc.gridx = 8;
		gbc.gridy = 0;
		JPanel oppReserve = new JPanel();
		oppReserve.setBackground(Color.RED);
		this.add(oppReserve, gbc);
		
		gbc.gridx = 12;
		gbc.gridy = 0;
		blankPanel = new JPanel();
		this.add(blankPanel, gbc);
		
		
		//front row
		gbc.gridx = 0;
		gbc.gridy = 3;
		JPanel oppBattlesite = new JPanel();
		oppBattlesite.setBackground(Color.RED);
		this.add(oppBattlesite, gbc);
		
		gbc.gridx = 4;
		gbc.gridy = 3;
		JPanel oppChar1 = new JPanel();
		oppChar1.setBackground(Color.RED);
		this.add(oppChar1, gbc);
		
		gbc.gridx = 8;
		gbc.gridy = 3;
		JPanel oppChar2 = new JPanel();
		oppChar2.setBackground(Color.RED);
		this.add(oppChar2, gbc);
		
		gbc.gridx = 12;
		gbc.gridy = 3;
		JPanel oppChar3 = new JPanel();
		oppChar3.setBackground(Color.RED);
		this.add(oppChar3, gbc);
	}
}
