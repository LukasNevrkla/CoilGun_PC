   M S B A M L   `   `   `  ����E  ACoilGun_PC, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:CoilGun_PC.ViewCoilGun_PC.View  5      #    CoilGun_PC.View.DB_connection   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:CoilGun_PC.View     5        � 	Resources  5
         
SecondText �� Mode  DataName��%�   &	��      7   &	 ^     7   �� 5   
   .R�5      �� 8��  ��6   �� *Column_name+$ OneTime=�6E   5      �� 5   
   .R�5      �� 8��  ��6   �� *	Data_name+$ OneTime=�6C   5      5      .��5      � $
��AUTO��6   $
��AUTO��6    J� OpacityMask 5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6    � Offset$ 0Q�6-   � 5      $ 	#FF663636��6   $ 1Q�61   5       J� Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5      .+�5   
   �� $��Připojení databáze��6     MainText#��[ 6.   $��10,10,10,305q�6P   �� 5    
   $��Název serveru:��6    �� TextAlignment$
 Left=�6*   #��[  6?   $��10,50,94,280q�6c   �� 5!   
   -   5        	 ��Name$	 	Server_tb��5!        SecondTextBox#��[ 6Q   $��111,50,10,280q�6x   ��6%   �� *Server_name+$ TwoWay=�6x   �� 5#   
   $��Název databáze:��6   $
 Left=�6+   #��[  6@   $��10,75,79,255q�6d   �� 5$   
   -   5        $��DB_tb��5$      #��[ 6I   $��126,75,10,255q�6p   ��6   �� *	DB_name+$ TwoWay=�6p   �� 5&   
   $��Název tabulky:��6   $
 Left=�6*   #��[  6?   $��10,100,94,230q�6c   �� 5'   
   -   5        $��TB_tb��5'      #��[ 6J   $��111,100,10,230q�6q   ��6    �� *	TB_name+$ TwoWay=�6q   �� 5)   
   $��Formát tabulky��6   $
 Left=�6*   #��[  6?   $��10,125,94,205q�6c   &   System.Windows.Controls.DataGrid  5*   
   -   5        
  Name$
 	Colums_dg��5*        DataGrid#���  6'      AutoGenerateColumns . $��10,150,10,40q�6�   ��6J   �� *
DataView+6�   �� 5,   
   -   5        $��
Connect_bt��5,      $��Connect��6$     SecondButton#��[ 6O   $��115,315,10,10q�6u   5-      50      