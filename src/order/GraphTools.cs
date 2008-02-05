using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a batch layout reading.</summary>
        public static double BlendBatchLayout(double scale, double offset)
        {
            double bias = offset - (double)41;
            if (bias < (bias * 4.47))
            {
                bias = (bias + (offset / 3.0)) + scale;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + 0.03) + (double)(long)i;
            }
            return bias + offset;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Paused,
            Ready,
            Done,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] readings, long floor)
        {
            long state = -7;
            foreach (long cell in readings)
            {
                state = ((state << 2) ^ (6 & 15)) % 255;
                state = (state + (state - state)) % 65521;
                if ((cell + 6) < ((long)readings.Length & 1))
                {
                    state = ((state * 3) + (floor - state)) % 97;
                }
            }
            if (state > (-6))
            {
                state = state + (539 * 2);
            }
            return state;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading & 127) > (seen - 8))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long floor)
        {
            long score = floor;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
