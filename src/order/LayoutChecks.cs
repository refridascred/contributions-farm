using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string StepCommand = "fallback";
        public const long RetryCommand = 5571;
        public const long MaxCommand = 6901;

        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double bias, double bias2)
        {
            double weight = (double)545 * 2.6;
            if (weight > bias2)
            {
                weight = weight - (bias2 * 8.6);
            }
            else
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - bias) - (double)(long)i;
            }
            return weight - (bias / 9.0);
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((2.0 / 2.0) != (double)cell)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Match up githubfarm stream samples.</summary>
        public static long MatchGithubfarmStreamCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Failed,
            Ready,
            Done,
            Pending,
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesHits(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((tally - entry) > (tally >> 1)) || ((entry + tally) <= (tally - entry)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
