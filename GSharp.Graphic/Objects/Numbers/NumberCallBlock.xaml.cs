﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GSharp.Graphic.Blocks;
using GSharp.Graphic.Holes;
using GSharp.Base.Cores;
using GSharp.Base.Objects;
using GSharp.Extension;
using GSharp.Base.Objects.Numbers;

namespace GSharp.Graphic.Objects.Numbers
{
    /// <summary>
    /// StringPropertyBlock.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class NumberCallBlock : NumberBlock, ICallBlock
    {

        public GCommand GCommand
        {
            get
            {
                return _GCommand;
            }
        }
        private GCommand _GCommand;

        public override GObject GObject
        {
            get
            {
                return GNumberCall;
            }
        }

        public override GNumber GNumber
        {
            get
            {
                return GNumberCall;
            }
        }

        public GNumberCall GNumberCall
        {
            get
            {
                return _GNumberCall;
            }
        }
        private GNumberCall _GNumberCall;

        public override List<GBase> ToGObjectList()
        {
            return _GObjectList;
        }

        public ICall ICall
        {
            get
            {
                return GNumberCall;
            }
        }

        private List<GBase> _GObjectList;

        // 생성자
        public NumberCallBlock(GCommand command)
        {
            InitializeComponent();

            _GCommand = command;
            _GNumberCall = new GNumberCall(command);
            _GObjectList = new List<GBase> { GObject };

            PropertyName.Text = command.FriendlyName;

            InitializeBlock();
        }
    }
}