   M S B A M L   `   `   `  ����E  ACoilGun_PC, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:CoilGun_PC.ViewCoilGun_PC.View  5      '    !CoilGun_PC.View.Serial_connection   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:CoilGun_PC.View     5      .��5	      �   J� Effect  5
   
   3  -System.Windows.Media.Effects.DropShadowEffect  5      .+�5   
   �� $��
Komunikace��6      MainText#��[  6&   $��10,10,10,255q�6H   �� 5   
   $��Port:��6   $��30��6!     
SecondText#��[ 6-   $��10,45,460,235q�6Q   �� 5   
   $��	Baudrate:��6   $��60��6%   #��[ 60   $��120,45,320,235q�6T   �� 5   
   -   5        $��Port_cb��5        ComboBoxStyle#��[ 6@   $��45,45,386,235q�6�   $��70��6�   �� 5   
   -   5        $��Baud_cb��5      #��[ 6"   $��80��6r   $��185,45,235,235q�6}   � 5   
   $��10,70,10,40q�6   .+�5      �� -   5        $��
Scroll_ser��5      $��Visible=�6-   ��. .��5      �� -   5         ��Name$ Serial_text��5       �� 
IsReadOnly .   SecondTextBox#��[ 6n   
���   �
�������$	��190��6�   ��6/   �� *Serial_data+ �� Mode$ OneTime=�6�   5      5      �� 5   
   $��Napiš zprávu...��6   #��[ 6)   
�������
���   �$��10,270,90,10q�6v   �� 5   
   $��Poslat��6   $��75��6"     SecondButton#��[ 6-   $��415,265,10,10q�6S   5      5      