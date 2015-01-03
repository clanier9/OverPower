package com.mlc.game.op.tabletop;

import java.awt.BorderLayout;
import javax.swing.JButton;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTextArea;
import javax.swing.JTextField;

public class ChatPanel extends JPanel {
	JPanel pnlChatInput = new JPanel();
	JPanel pnlChatOutput = new JPanel();
	JTextArea output = new JTextArea();
	JScrollPane outputPane = new JScrollPane(output);
	JTextField input = new JTextField("", 40);	
	JButton btnSubmit = new JButton("Submit");
	
	public ChatPanel() {
		this.setLayout(new BorderLayout());	
		pnlChatInput.setLayout(new BorderLayout());
		pnlChatOutput.setLayout(new BorderLayout());
				
		output.setRows(4);
		output.setLineWrap(true);
		output.setWrapStyleWord(true);
		output.setEnabled(false);
				
		pnlChatOutput.add(outputPane, BorderLayout.CENTER);
						
		pnlChatInput.add(input, BorderLayout.CENTER);
		pnlChatInput.add(btnSubmit, BorderLayout.EAST);
		
		this.add(pnlChatOutput, BorderLayout.CENTER);
		this.add(pnlChatInput, BorderLayout.SOUTH);
	}
}
