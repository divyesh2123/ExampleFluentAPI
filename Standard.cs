﻿namespace ExampleFluentAPI
{
    public class Standard
    {
        public int StandardId { get; set; }
        public string StandardName { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
