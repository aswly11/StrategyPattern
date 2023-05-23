using StrategyPattern;

Player player = new Warrior(new MagicAttackStrategy());
player.Attack();

Player player1 = new mage(new RangedAttackStrategy());
player1.Attack();