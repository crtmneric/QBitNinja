﻿using NBitcoin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapidBase.Models
{
    public class BlockInformation
    {
        public uint256 BlockId
        {
            get;
            set;
        }

        public BlockHeader BlockHeader
        {
            get;
            set;
        }
        public int Height
        {
            get;
            set;
        }
        public int Confirmations
        {
            get;
            set;
        }
    }
    public class GetTransactionResponse
    {
        public Transaction Transaction
        {
            get;
            set;
        }

        public uint256 TransactionId
        {
            get;
            set;
        }

        public BlockInformation Block
        {
            get;
            set;
        }

        public List<Coin> SpentCoins
        {
            get;
            set;
        }

        public Money Fees
        {
            get;
            set;
        }
    }
}