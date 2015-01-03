package com.mlc.game.op;

import java.awt.BorderLayout;
import java.awt.Dimension;

import javax.swing.JFrame;
import javax.swing.JPanel;

import com.mlc.game.op.tabletop.OppCharsPanel;
import com.mlc.game.op.tabletop.Tabletop;

public class OverPower {	
	
	public static void main(String[] args) {		
		JFrame table = new JFrame();
		table.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		table.setLayout(new BorderLayout());
				
		JPanel containerPane = new OppCharsPanel();
		table.add(containerPane);
		table.setLocationByPlatform(true);
				
		table.pack();
//		table.setExtendedState(table.getExtendedState() | JFrame.MAXIMIZED_BOTH);
		table.setLocationRelativeTo(null);
		table.setVisible(true);
	}	
	
}
