   M S B A M L   `   `   `  ����B  >MyGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:MyGamesMyGames  5   	       MyGames.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:MyGames     5   	   -   5          �Name$  MyGames��5   	    � Title$ MyGames��5   	   $	��350��6   $	��525��6&   .��5	      �  � ColumnDefinitions 5
   
   �� 5      .+�5   
   �� -   5         ��Name$ button��5      $��Hinzufügen��6!   $
��Left=�66   $��	10,10,0,0q�6Q   $	��Top=�6d   $��75��6|   $��20��6�   �� 5   
   -   5        $ button1��5      $��	Entfernen��6"   $
��Left=�66   $��	10,35,0,0q�6Q   $	��Top=�6d   $��75��6|   $��20��6�   �� 5   
   -   5        $ button2��5      $
��Play��6"   $
��Left=�61   $��	10,60,0,0q�6L   $	��Top=�6_   $��75��6w   $��20��6�   �� 5   
   -   5         ��Name$ listView��5      $	��299��6%   $��
95,10,10,0q�62   $	��Top=�6F   $��1q�6^    � ContextMenu 5      �� 5      -   5        $
��Menu��5      .@�5      m� -   5        $
��Play��5      6-   m� 5      -   5        $��	Entfernen��5      62   5       �� View 5      �� 5      ! �� ColumnHeaderContainerStyle 5      �� 5      .�5      ��  �� Property � y�	 �� Value$	 	Collapsed=�6L   5      .P�5      �� $
��Icon��6%   
 �� Width$

 auto��63    �� CellTemplate 5      �� 5       .R�5!   "   �� $
��auto��6(   $
��auto��65   $��Center=�6C   $��Center=�5"   %   ��6B   ��  �� Path$
 icon�5#      5%      �� 5&      $��Spiel��6%    �� DisplayMemberBinding 65   �� *game+ �� HeaderContainerStyle 5'      �� 5(       �� 
TargetType" ��6$   .�5)   "   ��  � ��	 6?   Z� �� 5*   "    � ��	 6?   Z� �� 5+   "    � ��	 6@   Z� �� 5,   "    � ��$
	 auto��6:   �� 5-   "    � y�$	 	Collapsed=�6P   5.      50      51      53      54      55      