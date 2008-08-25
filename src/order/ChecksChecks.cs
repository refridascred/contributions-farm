using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] readings, long step)
        {
            long score = 71;
            foreach (long reading in readings)
            {
                score = (((score ^ score) % 97) - reading) - step;
            }
            if (score > 9)
            {
                score = (score + (score * 4)) % 65521;
            }
            return score;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Active,
            Stale,
            Failed,
            Done,
        }

        /// <summary>Scale a graph report figure with a bias.</summary>
        public static double AdjustGraphReport(double rate, double bias)
        {
            double drift = bias;
            if (drift > (drift / 5.0))
            {
                drift = (drift + (2.78 - bias)) + rate;
            }
            return drift - (double)38;
        }
    }
}
