   M S B A M L   `   `   `  ���� O  KOptimization_Paragon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Optimization_ParagonOptimization_Paragon  %    Optimization_Paragon.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     4local"clr-namespace:Optimization_Paragon       � Title$  
MainWindow��$	��350��$	��525�� � SizeToContent$ Height=�.��]� .+��� -    ��Name$ SlPoints�� � Minimum$ 0Q� � Maximum$ 60Q�$	��Top=� � DataContext �� � $	��Top=�.+��� $��Points: ���� -    ��Name$ TbPoints������  �� ElementName$ SlPoints�� �� Path$ Value��� 
����� �$	��Top=�� $	��Top=�.+��� $0��*Switch To Crit (-6 Points when optimize): ���� -   $ TbCritRules���� 
����� �$	��Top=�� $	��Top=�.+��� $��Attack Speed: ���� -   $ TbAttackSpeed���� 
����� �$	��Top=�� $	��Top=�.+��� $��Crit Chance: ���� -   $ TbCritChance���� 
����� �$	��Top=�� $	��Top=�.+��� $��Critical Damage %: ���� -   	 ��Name$	 	CbCritDmg��$��60���� 
����� �$	��Top=�� $	��Top=�.+��� $��Power: ���� -   $ TbPower���� 
����� �$	��Top=�� $	��Top=�.+��� $��Increased Damage: ���� -   $ 	TbIncrDmg���� 
����� �$	��Top=��� -	   
 ��Name$
 BtnOptimizeDmg��$��Optimize Damage��$��20��$	��Top=�