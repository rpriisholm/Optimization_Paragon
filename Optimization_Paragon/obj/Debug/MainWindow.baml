   M S B A M L   `   `   `  ����O  KOptimization_Paragon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Optimization_ParagonOptimization_Paragon  5   	   %    Optimization_Paragon.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Optimization_Paragon     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)    � SizeToContent$ Height=�65   .��5	      ]� .+�5
   
   �� -   5         ��Name$ SlPoints��5
       � Minimum$ 0Q�6`    � Maximum$ 60Q�6l   $	��Top=�6y    � DataContext 6#   �� 6y   � 5   
   $	��Top=�6   .+�5      �� $��Points: ��6   �� 5      -   5         ��Name$ TbPoints��5      ��6*   ��  �� ElementName$ SlPoints�� �� Path$ Value�5      �� 5   
   
����� �$	��Top=�6&   � 5   
   $	��Top=�6   .+�5      �� $0��*Switch To Crit (-6 Points when optimize): ��6   �� 5      -   5        $ TbCritRules��5      5      �� 5   
   
����� �$	��Top=�6&   � 5   
   $	��Top=�6   .+�5      �� $��Attack Speed: ��6   �� 5      -   5        $ TbAttackSpeed��5      5      �� 5   
   
����� �$	��Top=�6&   � 5   
   $	��Top=�6   .+�5      �� $��Crit Chance: ��6   �� 5      -   5        $ TbCritChance��5      5      �� 5   
   
����� �$	��Top=�6&   � 5   
   $	��Top=�6   .+�5       �� $��Critical Damage %: ��6   �� 5!      -   5        	 ��Name$	 	CbCritDmg��5!      $��60��6*   65   5"      �� 5#   
   
����� �$	��Top=�6&   � 5$   
   $	��Top=�6   .+�5%      �� $��Power: ��6   �� 5&      -   5        $ TbPower��5&      5'      �� 5(   
   
����� �$	��Top=�6&   � 5)   
   $	��Top=�6   .+�5*      �� $��Increased Damage: ��6   �� 5+      -   5        $ 	TbIncrDmg��5+      5,      �� 5-   
   
����� �$	��Top=�6&   �� 5.   
   -	   5        
 ��Name$
 BtnOptimizeDmg��5.      $��Optimize Damage��6)   $��20��6C   $	��Top=�6l   5/      50      