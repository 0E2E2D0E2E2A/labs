   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp2WpfApp2  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089I2clr-namespace:System.Collections;assembly=mscorlibSystem.Collections 5   	   1&clr-namespace:System;assembly=mscorlibSystem 5	   	       WpfApp2.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp2     5   	   Bcol2clr-namespace:System.Collections;assembly=mscorlib     5   	   6sys&clr-namespace:System;assembly=mscorlib     5	   	     � Title$&   Бархатные тяги №1��5   	   $	��530��6#   $	��885��60   $	��500��6<   $	��880��6L   .��5      �  � RowDefinitions 5   
   �� 5      �� 5      $��67 �6   �� 5      $��0* �6    � ColumnDefinitions 5   
   �� 5      $
��267* �6   �� 5      $
��269* �6   �� 5      $
��349* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��dataGrid��5         AutoGenerateColumns .  $��2��6?   $��0,0,0,62q�6S   $��2��6e      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 120 63      MinWidth$	 100Q�6?   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6N   �� *Name+6i     5      $ Power��6%   $	 120 64   $	 100Q�6@    6O   �� *Power+6k     5      $ Volume��6%   $	 120 65   $	 100Q�6A    6P   �� *Volume+6m     5       $ Color��6%   $	 120 64   $	 100Q�6@    6O   �� *Color+6k   5"      �� 5$   
   -   5        	 ��Name$	 textBox_Name��5$      $��2��6(   $��	0,84,65,0q�68   
 �� TextWrapping$

 Wrap=�6K   $	��Top=�6_   $��39��6w    J� RenderTransformOrigin$ 0.5,0.5&�6�   $��Times New Roman)�6�   $��30(�6�   $��Right=�6�   $	��220��6�   �� 5%   
   -   5        $	 textBox_Power��5%      $��2��6)   $��
0,159,65,0q�69   $

 Wrap=�6M   $	��Top=�6a   $��39��6y   $��Times New Roman)�6�   $��30(�6�   $��Right=�6�   $	��220��6�   �� 5&   
   -   5        $	 textBox_Volume��5&      $��2��6*   $��Right=�6:   $��
0,238,65,0q�6V   $

 Wrap=�6j   $	��Top=�6~   $	��220��6�   $��39��6�   $��30(�6�   $��Times New Roman)�6�   �� 5'   
   $��2��6   $
��Name��6    $��
0,57,202,0q�6/   $	��Top=�6C   $��Times New Roman)�6[   $��18(�6x   $��27��6�   $��Right=�6�   $��95��6�   �� 5(   
   -   5        $	 textBox_Color��5(      $��2��6)   $��Right=�69   $��
0,320,65,0q�6U   $

 Wrap=�6i   $	��Top=�6}   $	��220��6�   $��39��6�   $��30(�6�   $��Times New Roman)�6�   �� 5)   
   $��2��6   $��Power��6    $��0,132,202,0q�60   $	��Top=�6E   $��Times New Roman)�6]   $��18(�6z   $��27��6�   $��Right=�6�   $��95��6�   �� 5*   
   $��2��6   $��Color��6    $��0,293,202,0q�60   $��Times New Roman)�6E   $��18(�6b   $��Right=�6p   $��95��6�   $��27��6�   $	��Top=�6�   �� 5+   
   -   5         ��Name$ add_btn_Click_1��5+      $��1��6*   $	��Add��6:   $��Center=�6H   $��Center=�6e   $��60��6�   $	��270��6�   $��1��6�   ���	#FF218D016�   �� 5,   
   -   5        $ delete_btn_Click_1��5,      $��Remove��6-   $��Center=�6>   $��1��6[   $��Center=�6h   $��60��6�   $	��267��6�   ���	#FF930D086�   �� 5-   
   $��2��6   $��Volume��6    $��0,205,201,0q�61   $��Times New Roman)�6F   $��18(�6c   $��28��6q   $	��Top=�6}   $��Right=�6�   $��96��6�   5.       � 	Resources 51       �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value��%�  '��       �� 52   
   " ��6   �53      �� 54       � ��
 �   �66   �� 55       � ��$ Times New Roman)�66   �� 56       � ��$ 20(�64   �� 57       � ��$ 1q�62    59      P� 5:       �@J�IsMouseOver . . �5;      ��  � ��$ 28(�61   �� 5<       � ��
 ��  �63   5=      P� 5?       �@J�IsMouseCaptured . . �5@      ��  � ��$ 32(�61   �� 5A       � ��
 � � �63   5B      5D      5E      5H      