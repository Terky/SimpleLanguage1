// This code was generated by the Gardens Point Parser Generator
// Copyright (c) Wayne Kelly, QUT 2005-2010
// (see accompanying GPPGcopyright.rtf)

// GPPG version 1.3.6
// Machine:  DESKTOP-32TFS7K
// DateTime: 31.10.2017 23:40:52
// UserName: wowit
// Input file <SimpleYacc.y>

// options: no-lines gplex

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using QUT.Gppg;
using ProgramTree;

namespace SimpleParser
{
public enum Tokens {
    error=1,EOF=2,BEGIN=3,END=4,CYCLE=5,ASSIGN=6,
    SEMICOLON=7,PLUS=8,MINUS=9,LEFT_BRACKET=10,RIGHT_BRACKET=11,DIV=12,
    MULT=13,VAR=14,COLON=15,COMMA=16,RETURN=17,INUM=18,
    DNUM=19,BVAL=20,ID=21};

public struct ValueType
{ 
			public bool bVal;
			public double dVal; 
			public int iVal; 
			public string sVal; 
			public Node nVal;
			public ExprNode eVal;
			public StatementNode stVal;
			public BlockNode blVal;
			public FunHeader fHead;
       }
// Abstract base class for GPLEX scanners
public abstract class ScanBase : AbstractScanner<ValueType,LexLocation> {
  private LexLocation __yylloc = new LexLocation();
  public override LexLocation yylloc { get { return __yylloc; } set { __yylloc = value; } }
  protected virtual bool yywrap() { return true; }
}

public class Parser: ShiftReduceParser<ValueType, LexLocation>
{
  // Verbatim content from SimpleYacc.y
// This defenition goes to class GPPGParser, which is a parser, that generated by gppg system
    public MainProgramNode root; // Syntax tree root 
    public Parser(AbstractScanner<ValueType, LexLocation> scanner) : base(scanner) { }
  // End verbatim content from SimpleYacc.y

#pragma warning disable 649
  private static Dictionary<int, string> aliasses;
#pragma warning restore 649
  private static Rule[] rules = new Rule[38];
  private static State[] states = new State[62];
  private static string[] nonTerms = new string[] {
      "expr", "ident", "term", "factor", "function", "fun_list", "fun_call", 
      "assign", "statement", "cycle", "decl", "return", "stlist", "block", "fun_header", 
      "progr", "$accept", "arguments", };

  static Parser() {
    states[0] = new State(new int[]{21,58},new int[]{-16,1,-6,3,-5,61,-15,5});
    states[1] = new State(new int[]{2,2});
    states[2] = new State(-1);
    states[3] = new State(new int[]{21,58,2,-2},new int[]{-5,4,-15,5});
    states[4] = new State(-4);
    states[5] = new State(new int[]{3,7},new int[]{-14,6});
    states[6] = new State(-5);
    states[7] = new State(new int[]{21,46,3,7,5,51,17,55,4,-17,7,-17},new int[]{-13,8,-9,57,-8,12,-2,13,-11,48,-14,49,-10,50,-12,54});
    states[8] = new State(new int[]{4,9,7,10});
    states[9] = new State(-34);
    states[10] = new State(new int[]{21,46,3,7,5,51,17,55,4,-17,7,-17},new int[]{-9,11,-8,12,-2,13,-11,48,-14,49,-10,50,-12,54});
    states[11] = new State(-11);
    states[12] = new State(-12);
    states[13] = new State(new int[]{6,14});
    states[14] = new State(new int[]{10,20,21,28,18,41,19,42,20,43},new int[]{-1,15,-3,45,-4,44,-2,27,-7,40});
    states[15] = new State(new int[]{8,16,9,23,4,-21,7,-21});
    states[16] = new State(new int[]{10,20,21,28,18,41,19,42,20,43},new int[]{-3,17,-4,44,-2,27,-7,40});
    states[17] = new State(new int[]{13,18,12,25,8,-22,9,-22,4,-22,7,-22,11,-22,21,-22,3,-22,5,-22,17,-22});
    states[18] = new State(new int[]{10,20,21,28,18,41,19,42,20,43},new int[]{-4,19,-2,27,-7,40});
    states[19] = new State(-25);
    states[20] = new State(new int[]{10,20,21,28,18,41,19,42,20,43},new int[]{-1,21,-3,45,-4,44,-2,27,-7,40});
    states[21] = new State(new int[]{11,22,8,16,9,23});
    states[22] = new State(-28);
    states[23] = new State(new int[]{10,20,21,28,18,41,19,42,20,43},new int[]{-3,24,-4,44,-2,27,-7,40});
    states[24] = new State(new int[]{13,18,12,25,8,-23,9,-23,4,-23,7,-23,11,-23,21,-23,3,-23,5,-23,17,-23});
    states[25] = new State(new int[]{10,20,21,28,18,41,19,42,20,43},new int[]{-4,26,-2,27,-7,40});
    states[26] = new State(-26);
    states[27] = new State(-29);
    states[28] = new State(new int[]{10,30,13,-20,12,-20,8,-20,9,-20,4,-20,7,-20,11,-20,21,-20,3,-20,5,-20,17,-20},new int[]{-18,29});
    states[29] = new State(-19);
    states[30] = new State(new int[]{21,36,11,39,10,30},new int[]{-18,31});
    states[31] = new State(new int[]{16,32});
    states[32] = new State(new int[]{21,33});
    states[33] = new State(new int[]{21,34});
    states[34] = new State(new int[]{11,35});
    states[35] = new State(-7);
    states[36] = new State(new int[]{21,37});
    states[37] = new State(new int[]{11,38});
    states[38] = new State(-8);
    states[39] = new State(-9);
    states[40] = new State(-30);
    states[41] = new State(-31);
    states[42] = new State(-32);
    states[43] = new State(-33);
    states[44] = new State(-27);
    states[45] = new State(new int[]{13,18,12,25,8,-24,9,-24,4,-24,7,-24,11,-24,21,-24,3,-24,5,-24,17,-24});
    states[46] = new State(new int[]{21,47,6,-20});
    states[47] = new State(-18);
    states[48] = new State(-13);
    states[49] = new State(-14);
    states[50] = new State(-15);
    states[51] = new State(new int[]{10,20,21,28,18,41,19,42,20,43},new int[]{-1,52,-3,45,-4,44,-2,27,-7,40});
    states[52] = new State(new int[]{8,16,9,23,21,46,3,7,5,51,17,55,4,-17,7,-17},new int[]{-9,53,-8,12,-2,13,-11,48,-14,49,-10,50,-12,54});
    states[53] = new State(-35);
    states[54] = new State(-16);
    states[55] = new State(new int[]{10,20,21,28,18,41,19,42,20,43,4,-37,7,-37},new int[]{-1,56,-3,45,-4,44,-2,27,-7,40});
    states[56] = new State(new int[]{8,16,9,23,4,-36,7,-36});
    states[57] = new State(-10);
    states[58] = new State(new int[]{21,59});
    states[59] = new State(new int[]{10,30},new int[]{-18,60});
    states[60] = new State(-6);
    states[61] = new State(-3);

    rules[1] = new Rule(-17, new int[]{-16,2});
    rules[2] = new Rule(-16, new int[]{-6});
    rules[3] = new Rule(-6, new int[]{-5});
    rules[4] = new Rule(-6, new int[]{-6,-5});
    rules[5] = new Rule(-5, new int[]{-15,-14});
    rules[6] = new Rule(-15, new int[]{21,21,-18});
    rules[7] = new Rule(-18, new int[]{10,-18,16,21,21,11});
    rules[8] = new Rule(-18, new int[]{10,21,21,11});
    rules[9] = new Rule(-18, new int[]{10,11});
    rules[10] = new Rule(-13, new int[]{-9});
    rules[11] = new Rule(-13, new int[]{-13,7,-9});
    rules[12] = new Rule(-9, new int[]{-8});
    rules[13] = new Rule(-9, new int[]{-11});
    rules[14] = new Rule(-9, new int[]{-14});
    rules[15] = new Rule(-9, new int[]{-10});
    rules[16] = new Rule(-9, new int[]{-12});
    rules[17] = new Rule(-9, new int[]{});
    rules[18] = new Rule(-11, new int[]{21,21});
    rules[19] = new Rule(-7, new int[]{21,-18});
    rules[20] = new Rule(-2, new int[]{21});
    rules[21] = new Rule(-8, new int[]{-2,6,-1});
    rules[22] = new Rule(-1, new int[]{-1,8,-3});
    rules[23] = new Rule(-1, new int[]{-1,9,-3});
    rules[24] = new Rule(-1, new int[]{-3});
    rules[25] = new Rule(-3, new int[]{-3,13,-4});
    rules[26] = new Rule(-3, new int[]{-3,12,-4});
    rules[27] = new Rule(-3, new int[]{-4});
    rules[28] = new Rule(-4, new int[]{10,-1,11});
    rules[29] = new Rule(-4, new int[]{-2});
    rules[30] = new Rule(-4, new int[]{-7});
    rules[31] = new Rule(-4, new int[]{18});
    rules[32] = new Rule(-4, new int[]{19});
    rules[33] = new Rule(-4, new int[]{20});
    rules[34] = new Rule(-14, new int[]{3,-13,4});
    rules[35] = new Rule(-10, new int[]{5,-1,-9});
    rules[36] = new Rule(-12, new int[]{17,-1});
    rules[37] = new Rule(-12, new int[]{17});
  }

  protected override void Initialize() {
    this.InitSpecialTokens((int)Tokens.error, (int)Tokens.EOF);
    this.InitStates(states);
    this.InitRules(rules);
    this.InitNonTerminals(nonTerms);
  }

  protected override void DoAction(int action)
  {
    switch (action)
    {
      case 2: // progr -> fun_list
{ root = ValueStack[ValueStack.Depth-1].eVal as MainProgramNode; }
        break;
      case 3: // fun_list -> function
{ CurrentSemanticValue.eVal = new MainProgramNode(ValueStack[ValueStack.Depth-1].eVal as FunNode); }
        break;
      case 4: // fun_list -> fun_list, function
{ (ValueStack[ValueStack.Depth-2].eVal as MainProgramNode).Add(ValueStack[ValueStack.Depth-1].eVal as FunNode); CurrentSemanticValue.eVal = ValueStack[ValueStack.Depth-2].eVal; }
        break;
      case 5: // function -> fun_header, block
{ CurrentSemanticValue.eVal = new FunNode(ValueStack[ValueStack.Depth-2].fHead, ValueStack[ValueStack.Depth-1].blVal); }
        break;
      case 6: // fun_header -> ID, ID, arguments
{ CurrentSemanticValue.fHead = new FunHeader(ValueStack[ValueStack.Depth-3].sVal, ValueStack[ValueStack.Depth-2].sVal); }
        break;
      case 10: // stlist -> statement
{ 
				CurrentSemanticValue.blVal = new BlockNode(ValueStack[ValueStack.Depth-1].stVal); 
			}
        break;
      case 11: // stlist -> stlist, SEMICOLON, statement
{ 
				if (ValueStack[ValueStack.Depth-1].stVal != null)
				{
					ValueStack[ValueStack.Depth-3].blVal.Add(ValueStack[ValueStack.Depth-1].stVal);
			    }
				CurrentSemanticValue.blVal = ValueStack[ValueStack.Depth-3].blVal; 
			}
        break;
      case 12: // statement -> assign
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-1].stVal; }
        break;
      case 13: // statement -> decl
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-1].stVal; }
        break;
      case 14: // statement -> block
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-1].blVal; }
        break;
      case 15: // statement -> cycle
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-1].stVal; }
        break;
      case 16: // statement -> return
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-1].stVal; }
        break;
      case 17: // statement -> /* empty */
{ CurrentSemanticValue.stVal = null; }
        break;
      case 18: // decl -> ID, ID
{ CurrentSemanticValue.stVal = new DeclNode(ValueStack[ValueStack.Depth-2].sVal, ValueStack[ValueStack.Depth-1].sVal); }
        break;
      case 19: // fun_call -> ID, arguments
{ CurrentSemanticValue.eVal = new FunCallNode(ValueStack[ValueStack.Depth-2].sVal); }
        break;
      case 20: // ident -> ID
{ CurrentSemanticValue.eVal = new IdNode(ValueStack[ValueStack.Depth-1].sVal); }
        break;
      case 21: // assign -> ident, ASSIGN, expr
{ CurrentSemanticValue.stVal = new AssignNode(ValueStack[ValueStack.Depth-3].eVal as IdNode, ValueStack[ValueStack.Depth-1].eVal); }
        break;
      case 22: // expr -> expr, PLUS, term
{ CurrentSemanticValue.eVal = new BinExprNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, OpType.Plus); }
        break;
      case 23: // expr -> expr, MINUS, term
{ CurrentSemanticValue.eVal = new BinExprNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, OpType.Minus); }
        break;
      case 24: // expr -> term
{ CurrentSemanticValue.eVal = ValueStack[ValueStack.Depth-1].eVal; }
        break;
      case 25: // term -> term, MULT, factor
{ CurrentSemanticValue.eVal = new BinExprNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, OpType.Mult); }
        break;
      case 26: // term -> term, DIV, factor
{ CurrentSemanticValue.eVal = new BinExprNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, OpType.Div); }
        break;
      case 27: // term -> factor
{ CurrentSemanticValue.eVal = ValueStack[ValueStack.Depth-1].eVal; }
        break;
      case 28: // factor -> LEFT_BRACKET, expr, RIGHT_BRACKET
{ CurrentSemanticValue.eVal = ValueStack[ValueStack.Depth-2].eVal; }
        break;
      case 29: // factor -> ident
{ CurrentSemanticValue.eVal = ValueStack[ValueStack.Depth-1].eVal as IdNode; }
        break;
      case 30: // factor -> fun_call
{ CurrentSemanticValue.eVal = ValueStack[ValueStack.Depth-1].eVal as FunCallNode; }
        break;
      case 31: // factor -> INUM
{ CurrentSemanticValue.eVal = new IntNumNode(ValueStack[ValueStack.Depth-1].iVal); }
        break;
      case 32: // factor -> DNUM
{ CurrentSemanticValue.eVal = new DoubleNumNode(ValueStack[ValueStack.Depth-1].dVal); }
        break;
      case 33: // factor -> BVAL
{ CurrentSemanticValue.eVal = new BoolNode(ValueStack[ValueStack.Depth-1].bVal); }
        break;
      case 34: // block -> BEGIN, stlist, END
{ CurrentSemanticValue.blVal = ValueStack[ValueStack.Depth-2].blVal; }
        break;
      case 35: // cycle -> CYCLE, expr, statement
{ CurrentSemanticValue.stVal = new CycleNode(ValueStack[ValueStack.Depth-2].eVal, ValueStack[ValueStack.Depth-1].stVal); }
        break;
      case 36: // return -> RETURN, expr
{ CurrentSemanticValue.stVal = new ReturnNode(ValueStack[ValueStack.Depth-1].eVal); }
        break;
      case 37: // return -> RETURN
{ CurrentSemanticValue.stVal = new ReturnNode(); }
        break;
    }
  }

  protected override string TerminalToString(int terminal)
  {
    if (aliasses != null && aliasses.ContainsKey(terminal))
        return aliasses[terminal];
    else if (((Tokens)terminal).ToString() != terminal.ToString(CultureInfo.InvariantCulture))
        return ((Tokens)terminal).ToString();
    else
        return CharToString((char)terminal);
  }


}
}
