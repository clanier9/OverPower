package com.mlc.game.op.tabletop;

import java.awt.Color;
import java.awt.Dimension;
import java.awt.GridBagConstraints;
import java.awt.GridBagLayout;
import java.awt.Insets;

import javax.swing.JPanel;

import com.mlc.game.op.card.Mission;

public class OppMissionsPanel extends JPanel {	
	Mission[] missionCards = new Mission[7];
	
	public OppMissionsPanel() {
		this.setLayout(new GridBagLayout());
		GridBagConstraints gbc = new GridBagConstraints();
		gbc.insets = new Insets(5, 15, 5, 15);
		
		gbc.gridx = 1;
		gbc.gridy = 0;	
		JPanel oppDefeated = new JPanel();
		oppDefeated.setBackground(Color.RED);
		this.add(oppDefeated, gbc);
		
		gbc.gridx = 1;
		gbc.gridy = 1;
		JPanel oppReserve = new JPanel();
		oppReserve.setBackground(Color.RED);
		this.add(oppReserve, gbc);
		
		gbc.gridx = 1;
		gbc.gridy = 2;
		JPanel oppCompleted = new JPanel();
		oppCompleted.setBackground(Color.RED);
		this.add(oppCompleted, gbc);
		
		gbc.gridx = 0;
		gbc.gridy = 1;
		JPanel oppReserveVentured = new JPanel();
		oppReserveVentured.setBackground(Color.RED);
		this.add(oppReserveVentured, gbc);
		
		gbc.gridx = 0;
		gbc.gridy = 2;
		JPanel oppCompletedVentured = new JPanel();
		oppCompletedVentured.setBackground(Color.RED);
		this.add(oppCompletedVentured, gbc);
	}
}
