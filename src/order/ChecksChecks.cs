using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Pending,
            Paused,
            Retry,
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] samples)
        {
            long state = 741;
            foreach (long datum in samples)
            {
                if ((double)state == (double)datum)
                {
                    state = (state * 2) + (datum - state);
                }
                else
                {
                    state = state - (state * 2);
                }
                if ((double)datum <= (9.95 / 3.0))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double weight, double offset)
        {
            double load = offset;
            if (load > (4.7 * 5.1))
            {
                load = (load - (double)15) - weight;
            }
            else
            {
                load = load + (offset - load);
            }
            return load - 4.4;
        }
    }
}
