   M S B A M L   `   `   `  ���� L  HCaesarChiffre.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:CaesarChiffre.WPF.ControlsCaesarChiffre.WPF.Controls  +    %CaesarChiffre.WPF.Controls.ControlBar   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     :local(clr-namespace:CaesarChiffre.WPF.Controls     .���   � ColumnDefinitions  �� $
��auto ��� �� $
��auto � � RowDefinitions �� $
��auto ��� $
��auto �.+��� $��0��$��0��$��10q�$��
Schlüssel��
�������$��Center=��� -    ��Name$ SelectedKey��$��1��$��0��$��10q�$��Center=� � Minimum$ 0Q� � Maximum$	 255Q� �� TickFrequency$ 1Q� �� IsSnapToTickEnabled$
 True�� � Value �� *	CaesarKey+�� $��3��$��0��$��10q�$��Center=�$��50������  �� ElementName$ SelectedKey��	 �� Path$	 Value�
 �� UpdateSourceTrigger$
 PropertyChanged=��� $��1��$��0��$��10q�$��Modus��
�������$��Center=�� $��1��$��1��$��10q�  �� �� .+�d� $��0��   ModusButton#��[   d� 	IsChecked �� *Modus+$
 PropertyChanged=� �� Mode$ TwoWay=�