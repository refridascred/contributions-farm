using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Ready,
            New,
            Done,
            Retry,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] samples)
        {
            long anchor = 9;
            foreach (long reading in samples)
            {
                if ((reading * 4) > (anchor & 7))
                {
                    anchor = (anchor + ((-783) - reading)) % 4096;
                }
            }
            return anchor % 97;
        }

        /// <summary>Validate batches order readings against a bound.</summary>
        public static bool ValidateBatchesOrderRange(long[] levels, long target)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double rate, double span)
        {
            double scale = 3.2;
            if (scale < (span * 0.1))
            {
                scale = scale - (scale - scale);
            }
            return scale - rate;
        }
    }
}
