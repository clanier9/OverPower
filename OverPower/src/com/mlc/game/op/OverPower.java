package com.mlc.game.op;

import java.awt.BorderLayout;
import java.awt.Dimension;

import javafx.application.Application;
import javafx.application.Platform;
import javafx.embed.swing.JFXPanel;
import javafx.geometry.Insets;
import javafx.scene.Group;
import javafx.scene.Scene;
import javafx.scene.image.Image;
import javafx.scene.image.ImageView;
import javafx.scene.layout.ColumnConstraints;
import javafx.scene.layout.GridPane;
import javafx.scene.layout.Pane;
import javafx.scene.layout.RowConstraints;
import javafx.stage.Stage;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.SwingUtilities;

import com.mlc.game.op.tabletop.OppCharsPanel;
import com.mlc.game.op.tabletop.OppMissionsPanel;
import com.mlc.game.op.tabletop.Tabletop;

//public class OverPower {	
//	
//	public static void main(String[] args) {
//        SwingUtilities.invokeLater(new Runnable() {
//            public void run() {
//                initAndShowGUI();
//            }
//        });
//    }
//	
////	public static void main(String[] args) {		
////		JFrame table = new JFrame();
////		table.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
//////		table.setLayout(new BorderLayout());
////		
//////		JPanel containerPane = new Tabletop();
//////		table.add(containerPane);
////		table.setLocationByPlatform(true);
////				
////		table.pack();
//////		table.setExtendedState(table.getExtendedState() | JFrame.MAXIMIZED_BOTH);
////		table.setLocationRelativeTo(null);
////		table.setVisible(true);
////	}	
//	
//	private static void initAndShowGUI() {
//        // This method is invoked on the EDT thread
//        JFrame frame = new JFrame();
//        final JFXPanel fxPanel = new JFXPanel();
//        frame.add(fxPanel);
//        frame.setVisible(true);
//        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
//
//        Platform.runLater(new Runnable() {
//            public void run() {
//                initFX(fxPanel);
//            }
//       });
//    }
//
//    private static void initFX(JFXPanel fxPanel) {
//        // This method is invoked on the JavaFX thread
//        Scene scene = createScene();
//        fxPanel.setScene(scene);
//    }
//
//    private static Scene createScene() {        
//        GridPane gp = new CopyOfOppCharsPanel();
//        Scene scene  =  new Scene(gp);
//
//        return (scene);
//    }
//	
//}

public class OverPower extends Application {
	 
    @Override
    public void start(final Stage stage) throws Exception {
        final GridPane oppCharsPane = new OppCharsPanel();        
                
        final Scene scene = new Scene(oppCharsPane);
        stage.setScene(scene);
        stage.setWidth(800);
        stage.setHeight(400);
        stage.show();
    }
    
     public static void main(String[] args) {
         Application.launch(args);
     }
 }

