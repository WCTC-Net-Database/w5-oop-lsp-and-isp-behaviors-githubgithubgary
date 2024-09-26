namespace W5_assignment_template.Interfaces
{
    public interface IEntity
    {
        string Name { get; set; }
        public void IEntity() { }
        void Move();
        void Attack(IEntity target);
        public interface IFlyable
        {
            void Fly();
        }
    }

}
