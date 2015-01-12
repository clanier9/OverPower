package com.mlc.game.op.tabletop;

import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.GridBagConstraints;
import java.awt.GridBagLayout;

import javafx.scene.image.Image;
import javafx.scene.image.ImageView;
import javafx.scene.layout.ColumnConstraints;
import javafx.scene.layout.GridPane;
import javafx.scene.layout.Pane;
import javafx.scene.layout.RowConstraints;
import javafx.geometry.Insets;

import javax.swing.JButton;
import javax.swing.JPanel;

public class OppCharsPanel extends GridPane {
	public OppCharsPanel() {
//		setLayout(new GridBagLayout());
//		GridBagConstraints gbc = new GridBagConstraints();
//		gbc.insets = new Insets(20, 15, 20, 15);
//		gbc.ipadx = 160;
//		gbc.ipady = 110;
//		gbc.fill = GridBagConstraints.BOTH;
//		gbc.weightx = 1.0;
//		gbc.weighty = 1.0;
//		
//		//back row
//		gbc.gridx = 8;
//		gbc.gridy = 0;
//		JPanel oppHomebase = new JPanel();
//		oppHomebase.setBackground(Color.RED);
//		this.add(oppHomebase, gbc);
//		
//		gbc.gridx = 16;
//		gbc.gridy = 0;
//		JPanel oppReserve = new JPanel();
//		oppReserve.setBackground(Color.RED);
//		this.add(oppReserve, gbc);
//		
//		
//		//front row
//		gbc.insets = new Insets(20, 15, 100, 15);
//		
//		gbc.gridx = 0;
//		gbc.gridy = 6;
//		JPanel oppBattlesite = new JPanel();
//		oppBattlesite.setBackground(Color.RED);
//		this.add(oppBattlesite, gbc);
//		
//		gbc.gridx = 8;
//		gbc.gridy = 6;
//		JPanel oppChar1 = new JPanel();
//		oppChar1.setBackground(Color.RED);
//		this.add(oppChar1, gbc);
//		
//		gbc.gridx = 16;
//		gbc.gridy = 6;
//		JPanel oppChar2 = new JPanel();
//		oppChar2.setBackground(Color.RED);
//		this.add(oppChar2, gbc);
//		
//		gbc.gridx = 24;
//		gbc.gridy = 6;
//		JPanel oppChar3 = new JPanel();
//		oppChar3.setBackground(Color.RED);
//		this.add(oppChar3, gbc);
		
		ColumnConstraints column1 = new ColumnConstraints();
        column1.setPercentWidth(25);
        ColumnConstraints column2 = new ColumnConstraints();
        column2.setPercentWidth(25);
        ColumnConstraints column3 = new ColumnConstraints();
        column1.setPercentWidth(25);
        ColumnConstraints column4 = new ColumnConstraints();
        column2.setPercentWidth(25);
        getColumnConstraints().addAll(column1, column2, column3, column4); 

        RowConstraints row1 = new RowConstraints();
        row1.setPercentHeight(50);
        RowConstraints row2 = new RowConstraints();
        row2.setPercentHeight(50);
        getRowConstraints().addAll(row1, row2); 
        
        final ImageView oppHomebase = new ImageView(new Image("1.png"));
        final ImageView oppChar4 = new ImageView(new Image("1.png"));
        final ImageView oppChar3 = new ImageView(new Image("1.png"));
        final ImageView oppChar2 = new ImageView(new Image("1.png"));
        final ImageView oppChar1 = new ImageView(new Image("1.png"));
        final ImageView oppBattlesite = new ImageView(new Image("1.png"));
        final Pane pH = new Pane();
        final Pane p4 = new Pane();
        final Pane p3 = new Pane();
        final Pane p2 = new Pane();
        final Pane p1 = new Pane();
        final Pane pB = new Pane();
        pH.setMinSize(42, 30);
        p4.setMinSize(42, 30);
        p3.setMinSize(42, 30);
        p2.setMinSize(42, 30);
        p1.setMinSize(42, 30);
        pB.setMinSize(42, 30);
        oppHomebase.fitWidthProperty().bind(pH.widthProperty());
        oppChar4.fitWidthProperty().bind(p4.widthProperty());
        oppChar3.fitWidthProperty().bind(p3.widthProperty());
        oppChar2.fitWidthProperty().bind(p2.widthProperty());
        oppChar1.fitWidthProperty().bind(p1.widthProperty());
        oppBattlesite.fitWidthProperty().bind(pB.widthProperty());
        oppHomebase.fitHeightProperty().bind(pH.heightProperty());
        oppChar4.fitHeightProperty().bind(p4.heightProperty());
        oppChar3.fitHeightProperty().bind(p3.heightProperty());
        oppChar2.fitHeightProperty().bind(p2.heightProperty());
        oppChar1.fitHeightProperty().bind(p1.heightProperty());
        oppBattlesite.fitHeightProperty().bind(pB.heightProperty());
        oppHomebase.setPreserveRatio(true);
        oppChar4.setPreserveRatio(true);
        oppChar3.setPreserveRatio(true);
        oppChar2.setPreserveRatio(true);
        oppChar1.setPreserveRatio(true);
        oppBattlesite.setPreserveRatio(true);
        pH.getChildren().add(oppHomebase);
        p4.getChildren().add(oppChar4);
        p3.getChildren().add(oppChar3);
        p2.getChildren().add(oppChar2);
        p1.getChildren().add(oppChar1);
        pB.getChildren().add(oppBattlesite);
        getChildren().add(pH);
        getChildren().add(p4);
        getChildren().add(p3);
        getChildren().add(p2);
        getChildren().add(p1);
        getChildren().add(pB);
        GridPane.setConstraints(pH, 1, 0);
        GridPane.setConstraints(p4, 2, 0);
        GridPane.setConstraints(p3, 3, 1);
        GridPane.setConstraints(p2, 2, 1);
        GridPane.setConstraints(p1, 1, 1);
        GridPane.setConstraints(pB, 0, 1);
        setHgap(20);
        setVgap(40);
        setPadding(new Insets(20, 20, 100, 20));
	}
}
