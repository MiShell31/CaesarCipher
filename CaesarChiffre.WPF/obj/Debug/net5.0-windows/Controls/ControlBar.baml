   M S B A M L   `   `   `  ����L  HCaesarChiffre.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:CaesarChiffre.WPF.ControlsCaesarChiffre.WPF.Controls  5      +    %CaesarChiffre.WPF.Controls.ControlBar   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:CaesarChiffre.WPF.Controls     5      .��5	      �   � ColumnDefinitions  5
   
   �� 5      $
��auto �6   �� 5      �� 5      $
��auto �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6   $��0��6$   $��10q�61   $��
Schlüssel��5      
�������$��Center=�5      �� 5   
   -   5         ��Name$ SelectedKey��5      $��1��6&   $��0��66   $��10q�6C   $��Center=�5       � Minimum$ 0Q�5       � Maximum$	 255Q�6    �� TickFrequency$ 1Q�5       �� IsSnapToTickEnabled$
 True��6#    � Value 5      �� *	CaesarKey+5   #   �� 5   
   $��3��5      $��0��6"   $��10q�6/   $��Center=�5      $��50��5      ��5      ��  �� ElementName$ SelectedKey��	 �� Path$	 Value�
 �� UpdateSourceTrigger$
 PropertyChanged=�5      �� 5   
   $��1��6   $��0��6!   $��10q�61   $��Modus��5       
�������$��Center=�5!      � 5"   
   $��1��6   $��1��6   $��10q�6,     5#      �� 5$      �� 5%      .+�5'      d� $��0��6      ModusButton#��[  5(       d� 	IsChecked 5'   +   �� *Modus+$
 PropertyChanged=� �� Mode$ TwoWay=�5(      5)      5*      5+      