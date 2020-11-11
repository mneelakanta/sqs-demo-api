using System;

namespace DemoApi
{
    public class IndividualTaxReturn
    {
        public User User { get; set; }

        public float Salary { get; set; }

        public float TotalTaxWithheld { get; set; }

        public int Year { get; set; }

        public Guid Id { get; set; }

        public LodgementStatus Status { get; set; }    

    }

    public enum LodgementStatus
    {
        Draft,
        InReview,
        Lodged
    }
}
