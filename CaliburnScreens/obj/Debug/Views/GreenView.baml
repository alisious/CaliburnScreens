   M S B A M L   `   `   `  ����c  _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity  5       CaliburnScreens%   CaliburnScreens.Views.GreenView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5      ^ ZCaliburn.Micro.Platform, Version=2.0.1.0, Culture=neutral, PublicKeyToken=8e5891231f2ed21f(calhttp://www.caliburnproject.org  5        � 	Resources  5
       �� 
TargetType �� Property �� Value �� CornerRadius � ToolTip �� ElementName �� Path��%�  '��       �� 5   
   " ��6   .�5      ��  � ��$ Center=�62   �� 5       � ��$ 0,2,40,2q�6'   �� 5       �@=�ErrorTemplate 5      �� 5      .R�5      ]� ��. .+�5      �� 
���  ��$��right=�62   $��5,0,0,0q�6I   $��20��6Z   $��20��6e   $ 10��6q    5      �� $ customAdorner��$8 2AdornedElement.(Validation.Errors)[0].ErrorContent�._�5      �� $��!��6(   $��center=�61   $��center=�6L   $
��Bold"�6i   
�������5      5      �� 5      $��customAdorner��64   $��Center=�6I   .v�5      �� 
���  ��$��1q�67   5      5      5      5      5      5      .��5       �  � ColumnDefinitions 5!   
   �� 5"      $	��300 �6   �� 5#      $
��300* �6   	 � RowDefinitions	 5%   
   �� 5&      $��70 �6   �� 5'      $��60 �6   �� 5(      $	��60* �6   .+�5*   
   �� .��5+   
   �� $��0��6   $��0��6%   .+�5,      �� $��Osoba sprawdzana��6   $��30(�6/   $
��Bold"�6=   
��� � �$��48��6b   �� 5-      -   5        
 ��Name$
 CanSearchAutomatically��5-      $��Szukaj automatycznie��68   $
��Left=�6W    d� IsThreeState .  $��10,0,0,0q�6�   5/      50      �� 51   
   -   5         ��Name$ SearchField��51        Caliburn.Micro.Message   Attach$. ([Event TextChanged] = [Action CopyField]��52      $
��Left=�53      $��23��6-   $��	10,10,0,0q�69   $��1��6L    �� TextWrapping$
 Wrap=�6Y   $	��Top=�6m   $	��166��6�   ��51   '   �� $ SearchField� �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors . .��53   �   54      �� 55   
   -   5         ��Name$ DestinationField��55      $
��Left=�6.   $��	10,26,0,0q�6I   $��2��6\   $
��Wrap=�6i   $	��Top=�6~   $	��166��6�   �� 56   
   -   5         ��Name$ ForceCopyField��56      $��Szukaj��57      $
��Left=�58      $��
215,10,0,0q�6,   $��1��6@   $	��Top=�6M   $��75��6e   �� 59   
   -   5        $ ShowRedScreen��59      $��Show Red Screen��5:      $	��100��5;      $��40��5<      $��1��5=      5>      5?      