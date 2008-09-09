using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] levels, long step)
        {
            long acc = 2;
            foreach (long sample in levels)
            {
                acc = ((acc << 3) ^ step) + sample;
            }
            if (acc > 509)
            {
                acc = ((acc << 3) ^ (step - 73)) % 4096;
            }
            return acc;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] readings)
        {
            long state = 6;
            foreach (long reading in readings)
            {
                state = (state + (2 + state)) % 65521;
                if ((reading % 100) < (state * 2))
                {
                    state = ((state << 3) ^ reading) % 101;
                }
            }
            if (state < 25)
            {
                state = ((state * 4) + (state - state)) % 101;
            }
            return state % 1000;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] items)
        {
            long result = 878;
            foreach (long reading in items)
            {
                if ((reading - result) <= (293 - reading))
                {
                    result = (result << 3) ^ (result + result);
                }
            }
            if (result > 17)
            {
                result = result + (result << 2);
            }
            return result;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public double Rank { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
