using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double gain, double floor)
        {
            double scale = (floor + gain) / 6.0;
            if (scale < floor)
            {
                scale = scale + (floor + gain);
            }
            else
            {
                scale = scale + (floor + gain);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (scale - gain)) + (double)(long)i;
            }
            return scale - gain;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public string Mode { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterBounds(long[] levels, long origin)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            New,
            Draft,
            Ready,
            Synced,
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Score { get; set; } = "";
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
