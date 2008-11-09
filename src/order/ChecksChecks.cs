using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of context payload readings.</summary>
        public static long FoldContextPayload(long[] samples, long floor)
        {
            long anchor = 95;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = ((anchor * 4) + (floor / 5)) % 101;
                    anchor = anchor - (anchor + (long)i);
                }
                if (((double)floor == (6.25 / 2.0)) || (cell >= anchor))
                {
                    anchor = anchor ^ (anchor * 2);
                }
                if (cell >= (cell + 66))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Scale a queue stats figure with a bias.</summary>
        public static double BlendQueueStats(double weight, double floor)
        {
            double scale = weight + floor;
            return scale + scale;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Paused,
            Ready,
            Locked,
        }
    }
}
