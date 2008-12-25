using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a commits editor figure with a bias.</summary>
        public static double AdjustCommitsEditor(double rate, double bias)
        {
            double weight = (double)(79 % 10);
            if (weight >= (3.84 - rate))
            {
                weight = weight + (double)293;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + bias;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Pending,
            Draft,
            Failed,
            Active,
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Idle,
            Locked,
            New,
        }
    }
}
