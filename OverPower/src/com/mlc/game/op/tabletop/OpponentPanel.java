package com.mlc.game.op.tabletop;

import java.awt.*;

import javax.swing.*;

public class OpponentPanel extends JPanel {
	public OpponentPanel() {
//		this.setLayout(new BorderLayout());
//		this.add(new OppMissionPanel(), BorderLayout.WEST);
//		this.add(new OppCharPanel(), BorderLayout.CENTER);
//		this.add(new OppPilesPanel(), BorderLayout.EAST);
		
		this.setLayout(new GridBagLayout());
		GridBagConstraints gbc = new GridBagConstraints();
		gbc.fill = GridBagConstraints.BOTH;
		gbc.weightx = 1.0;
		gbc.weighty = 1.0;
		
		gbc.gridx = 0;
		gbc.gridy = 0;	
		this.add(new OppMissionsPanel(), gbc);
		
		gbc.gridx = 1;
		gbc.gridy = 0;
//		this.add(new OppCharsPanel(), gbc);
		
		gbc.gridx = 2;
		gbc.gridy = 0;
		this.add(new OppPilesPanel(), gbc);
	}
}
