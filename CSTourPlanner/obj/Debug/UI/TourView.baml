   M S B A M L   `   `   `  ����H  DCSTourPlanner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:CSTourPlanner.UICSTourPlanner.UI  5   	   3clr-namespace:CSTourPlanner.VMCSTourPlanner.VM  5   	       CSTourPlanner.UI.TourView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:CSTourPlanner.UI     5   	   5
ViewModelsclr-namespace:CSTourPlanner.VM     5   	     � Title$  Tour-Planner��5
   	   $	��500��6    � 
ResizeMode$ NoResize=�6+   $	��574��6B    � Icon$ ../ASSETS/icon.ico��6N    � 	Resources 5      $   CSTourPlanner.VM.TourViewModel   TourViewModel��%   &	          5   
   6#   5       � DataContext 5        5   
   ��5      �� 5   
    �� EndPoint$ 0.7,1&�6    �� 
StartPoint$ 0,0.7&�6/   .��5      �  � Color$ Black��6   � 5      $ DarkGray��6    � Offset$ 6Q�6,   5      .��5      �  6   �� 	 �� Source#	 [  
 � ColumnDefinitions
 5   
   �� 5      $	��13* �6   �� 5      $	��25* �6    � RowDefinitions 5#   
   �� 5%      $��8* �6   �� 5&      $��7* �6   �� 5'      $
��142* �6   .+�5+   
   ]� $��2��6   $��0��6(   .+�5,      o� $	��Top=�6   $��30��6(   $
��Bold"�65   
��� � �$��
Doppio One)�6Z   $��15(�6r   ��5-      �� 5.      $ 0.7,1&�6*   $ 0.5,0&�6;   .��5/      � $ Black��6'   $ 0Q�65   � 50      $ DarkGray��6'   $ 3Q�68   51      .@�53      m� $��_File��6   .@�54      m� $
��Load��6    m� Command 6-   �� *LoadTourAsFileCommand+m� 55      $
��Save��6    6-   �� *SaveTourAsFileCommand+57      m� 58      $��_Edit��6   59      m� 5:      $��Options��6   $	��287��6,   5;      m� 5<      $
��Help��6   5=      �� 5?      5@      ]� 5A   
   $��2��6   $��1��6(   .+�5B      ��   
LabelStyle#��[ 6   $��Search:��68   6L   �� 5C      -   5        $��	SearchBar��5C   ~     TBStyle#��[ 6E   $��15��6f   $	��276��6r   $��	142 3 0 3q�6�   ��6   �� *SearchTextstring+ �� Mode$ TwoWay=�6�   � 5D      $��2 2 2 2q�6   .+�5E      �� $��17��6?   $��17��6K   ��6   �� *SearchTextCommand+��5F      �� 5G       �� ImageSource$ 
Search.png��6%   5J      �� 5K      $��2 0 0 0q�6@   $��17��6Q   $��17��6]   ��6   �� *ReportAsPdfCommand+��5L      �� 5M      $ printer.png��6%   5O      5P      5Q      �� 5R   
   $��2��6   $��0��6"    �� Orientation$ Vertical=�62   .+�5S      �� $ 
Horizontal=�6   $��38��62   .+�5T      �� #��[ 6   $��2q�6<   $��17(�6G   $��Tours��6U   $
��Bold"�6e   6y   �� 5U      $��30��6=   $��30��6I   $��3 4 3 0q�6T   ��6   �� *AddTourCommand+��5V      �� 5W      $ plus.png��6%   5Y      �� 5Z      $��30��6<   $��30��6H   $��3 4 3 0q�6S   ��6   �� *DelTourCommand+��5[      �� 5\      $ min.png��6%   5_      �� 5`      $��30��6=   $��30��6I   $��3 4 3 0q�6T   ��6   �� *EditTourCommand+��5a      �� 5b      $ edit.png��6%   5e      5f      �� 5g      -   5        $��ToursListBox��5g      $	��381��6,   $��3 3 3 3q�69   $��10(�6J   
���/���$��
Doppio One)�6�    �� SelectedItem 6X   �� *Tour+$ TwoWay=���6�   �� *
AllTours+$ TwoWay=���5h      �� 5i      $ 0.7,1&�6*   $ 0.1,0&�6;   .��5j      � $ Black��6'   $	 0.3Q�65   � 5k      $ White��6'   $ 4Q�65   5l       �� View 5n      �� 5o      .P�5p      �� $��Title��6)    �� Width$ 80��6d    �� DisplayMemberBinding 68   �� *
TourName+6d   �� 5q      $��Description��6)   $	 100��6q    6>   �� *TourDescription+6q   5r      5t      5u      �� 5v   
   $
��Left=�6   $	��182��6+   $	��Top=�68   $	��352��6P   $��135,202,0,0q�6\   $��2��6q   $��2��6   $��backgorund.png��6�   �� 5x   
   $��2��6   $��1��6"   $ Vertical=�62   $��3,0,0,49q�6J   .+�5y      �� $��Title: ��6   #��[ 6(   $	��0 2q�6L   $��17(�6Z   $
��Bold"�6h   $��35��6z   �� 5z      $��12,0,0,0q�6   $��1��6+   $��2��6;   $	��292��6H   $	��332��6U    J� Opacity$	 0.8Q�6a   
������� J� RenderTransformOrigin$ 0.326,0.521&�6�   $
��Left=�6�   ��5{      �� 5|      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5}      � $ Black��6'   $ 0Q�65   � 5~      $ White��6'   $ 6Q�65   5      .@�5�      �� $��Route��6   $��
Doppio One)�6*   
��� � �
���   �.��5�      � $��10 10 10 10q�6     � Orientation$ Vertical=�65   .+�5�      � $ Vertical=�6$   .+�5�      � $��1 1 1 1q�6(   $ 
Horizontal=�69   $	��306��6R   .+�5�   "   �� #��[ 6(   $��	Title:   ��6L   �� 5�   "   #��[ 6W   ��6*   �� *Tour.TourName+$ TwoWay=�6W   �� 5�   "   #��[ 6(   $��	Distance:��6L   �� 5�   "   #��[ 6\   $��77��6}   ��6*   �� *Tour.TourDistance+$ TwoWay=�6}   5�      � 5�      $��1 1 1 1q�6(   $ 
Horizontal=�69   .+�5�   "   �� #��[ 6(   $��Route:��6L   �� 5�   "   -   5        $��Routeb��5�   *   #��[ 6g   ��68   �� *Tour.RouteInfo+$ TwoWay=�6g   �� 5�   "   -   5        
��� � �$��10 0 0 0q�5�   O   $��20��6a   $��20��6l   $��GO��6x   6�   5�      5�      � 5�      $��1 1 1 1q�6$   $ 
Horizontal=�65   .+�5�      �� #��[ 6$   $��Map: ��6H   �� 5�      -   5        $��mapImage��5�   $   $��4q�64   $	��150��6?   $	��150��6L   6Z   �� 5�      .+�5�   "   �� #��[ 6(   $��Tour Description: ��6L   �� 5�   "   #��[ 6_   $��83��6�   $��50��6�   ��6*   �� *Tour.TourDescription+$ TwoWay=�6�   5�      5�      5�      5�      �� 5�      $��Description��6   $��
Doppio One)�6/   
��� � �
���   �.��5�      �� $ Vertical=�6!   .+�5�      �� -   5         ��Name$ LogsLV��5�   $   $	��200��64   $��
Doppio One)�6b   
�������
��� � �$��9(�6�   
�������$��2,16,2,5q�6�    6D   �� *Log+��6�   �� *Tour.TourLogs+$ TwoWay=� 5�      �� 5�   "   .P�5�   &   �� $
��Date��65   $ 45��6l    6C   �� *Date+6l   �� 5�   &   $��Distance��65   $ 50��6s    6G   �� *
Distance+6s   �� 5�   &   $��	TotalTime��65   $ 50��6u    6H   �� *	TotalTime+6u   �� 5�   &   $��Rating��65   $ 35��6o    6E   �� *Rating+6o   �� 5�   &   $��Joule��65   $ 30��6m    6D   �� *Joule+6m   �� 5�   &   $��Torque��65   $ 50��6o    6E   �� *Torque+6o   �� 5�   &   $��Momentum��65   $ 60��6s    6G   �� *
Momentum+6s   5�   #   5�      �� 5�      $ 
Horizontal=�6%   $��35��6>   $��0,0,2,0q�6J   .+�5�      �� $��30��6G   $��30��6S   $��3 4 3 0q�6^   ��6%   �� *AddLogCommand+��5�   "   �� 5�   &   $ plus.png��61   5�      �� 5�      $��30��6G   $��30��6S   $��3 4 3 0q�6^   ��6%   �� *DelLogCommand+��5�   "   �� 5�   &   $ min.png��61   5�      �� 5�      -   5        $��30��5�   H   $��30��6T   $��3 4 3 0q�6_   ��6%   �� *EditLogCommand+��5�   "   �� 5�   &   $ edit.png��61   5�      5�      5�      5�      5�      5�      5�      5�      