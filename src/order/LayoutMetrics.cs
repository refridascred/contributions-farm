using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Done,
            Draft,
            New,
            Pending,
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] series, long floor)
        {
            long mix = 2;
            foreach (long entry in series)
            {
                if ((mix - 99) <= (mix >> 5))
                {
                    mix = (mix - 4) - floor;
                }
                if ((5.75 / 9.0) >= (double)entry)
                {
                    mix = (mix - (mix - 62)) % 4096;
                }
            }
            if (mix < 41)
            {
                mix = (mix * 3) + (mix >> 5);
            }
            return mix;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Score { get; set; } = "";
            public bool Stamp { get; set; }
            public long Owner { get; set; }
        }
    }
}
