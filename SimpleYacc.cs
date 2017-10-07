// This code was generated by the Gardens Point Parser Generator
// Copyright (c) Wayne Kelly, QUT 2005-2010
// (see accompanying GPPGcopyright.rtf)

// GPPG version 1.3.6
// Machine:  DESKTOP-UBUV8QQ
// DateTime: 10/7/2017 9:10:55 PM
// UserName: artem
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
    SEMICOLON=7,PLUS=8,MINUS=9,INUM=10,RNUM=11,ID=12};

public struct ValueType
{ 
			public double dVal; 
			public int iVal; 
			public string sVal; 
			public Node nVal;
			public ExprNode eVal;
			public StatementNode stVal;
			public BlockNode blVal;
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
// ��� ���������� ����������� � ����� GPPGParser, �������������� ����� ������, ������������ �������� gppg
    public BlockNode root; // �������� ���� ��������������� ������ 
    public Parser(AbstractScanner<ValueType, LexLocation> scanner) : base(scanner) { }
  // End verbatim content from SimpleYacc.y

#pragma warning disable 649
  private static Dictionary<int, string> aliasses;
#pragma warning restore 649
  private static Rule[] rules = new Rule[17];
  private static State[] states = new State[27];
  private static string[] nonTerms = new string[] {
      "expr", "ident", "term", "assign", "statement", "cycle", "stlist", "block", 
      "progr", "$accept", };

  static Parser() {
    states[0] = new State(new int[]{3,4},new int[]{-9,1,-8,3});
    states[1] = new State(new int[]{2,2});
    states[2] = new State(-1);
    states[3] = new State(-2);
    states[4] = new State(new int[]{12,16,3,4,5,23},new int[]{-7,5,-5,26,-4,9,-2,10,-8,21,-6,22});
    states[5] = new State(new int[]{4,6,7,7});
    states[6] = new State(-15);
    states[7] = new State(new int[]{12,16,3,4,5,23},new int[]{-5,8,-4,9,-2,10,-8,21,-6,22});
    states[8] = new State(-4);
    states[9] = new State(-5);
    states[10] = new State(new int[]{6,11});
    states[11] = new State(new int[]{12,16,10,17},new int[]{-1,12,-3,20,-2,15});
    states[12] = new State(new int[]{8,13,9,18,4,-9,7,-9});
    states[13] = new State(new int[]{12,16,10,17},new int[]{-3,14,-2,15});
    states[14] = new State(-12);
    states[15] = new State(-10);
    states[16] = new State(-8);
    states[17] = new State(-11);
    states[18] = new State(new int[]{12,16,10,17},new int[]{-3,19,-2,15});
    states[19] = new State(-13);
    states[20] = new State(-14);
    states[21] = new State(-6);
    states[22] = new State(-7);
    states[23] = new State(new int[]{12,16,10,17},new int[]{-1,24,-3,20,-2,15});
    states[24] = new State(new int[]{8,13,9,18,12,16,3,4,5,23},new int[]{-5,25,-4,9,-2,10,-8,21,-6,22});
    states[25] = new State(-16);
    states[26] = new State(-3);

    rules[1] = new Rule(-10, new int[]{-9,2});
    rules[2] = new Rule(-9, new int[]{-8});
    rules[3] = new Rule(-7, new int[]{-5});
    rules[4] = new Rule(-7, new int[]{-7,7,-5});
    rules[5] = new Rule(-5, new int[]{-4});
    rules[6] = new Rule(-5, new int[]{-8});
    rules[7] = new Rule(-5, new int[]{-6});
    rules[8] = new Rule(-2, new int[]{12});
    rules[9] = new Rule(-4, new int[]{-2,6,-1});
    rules[10] = new Rule(-3, new int[]{-2});
    rules[11] = new Rule(-3, new int[]{10});
    rules[12] = new Rule(-1, new int[]{-1,8,-3});
    rules[13] = new Rule(-1, new int[]{-1,9,-3});
    rules[14] = new Rule(-1, new int[]{-3});
    rules[15] = new Rule(-8, new int[]{3,-7,4});
    rules[16] = new Rule(-6, new int[]{5,-1,-5});
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
      case 2: // progr -> block
{ root = ValueStack[ValueStack.Depth-1].blVal; }
        break;
      case 3: // stlist -> statement
{ 
				CurrentSemanticValue.blVal = new BlockNode(ValueStack[ValueStack.Depth-1].stVal); 
			}
        break;
      case 4: // stlist -> stlist, SEMICOLON, statement
{ 
				ValueStack[ValueStack.Depth-3].blVal.Add(ValueStack[ValueStack.Depth-1].stVal); 
				CurrentSemanticValue.blVal = ValueStack[ValueStack.Depth-3].blVal; 
			}
        break;
      case 5: // statement -> assign
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-1].stVal; }
        break;
      case 6: // statement -> block
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-1].blVal; }
        break;
      case 7: // statement -> cycle
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-1].stVal; }
        break;
      case 8: // ident -> ID
{ CurrentSemanticValue.eVal = new IdNode(ValueStack[ValueStack.Depth-1].sVal); }
        break;
      case 9: // assign -> ident, ASSIGN, expr
{ CurrentSemanticValue.stVal = new AssignNode(ValueStack[ValueStack.Depth-3].eVal as IdNode, ValueStack[ValueStack.Depth-1].eVal); ((IdNode)ValueStack[ValueStack.Depth-3].eVal).Value = ValueStack[ValueStack.Depth-1].eVal.Eval(); }
        break;
      case 10: // term -> ident
{ CurrentSemanticValue.eVal = ValueStack[ValueStack.Depth-1].eVal as IdNode; }
        break;
      case 11: // term -> INUM
{ CurrentSemanticValue.eVal = new IntNumNode(ValueStack[ValueStack.Depth-1].iVal); }
        break;
      case 12: // expr -> expr, PLUS, term
{ CurrentSemanticValue.eVal = new BinExprNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, OpType.Plus); }
        break;
      case 13: // expr -> expr, MINUS, term
{ CurrentSemanticValue.eVal = new BinExprNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, OpType.Minus); }
        break;
      case 14: // expr -> term
{ CurrentSemanticValue.eVal = ValueStack[ValueStack.Depth-1].eVal; }
        break;
      case 15: // block -> BEGIN, stlist, END
{ CurrentSemanticValue.blVal = ValueStack[ValueStack.Depth-2].blVal; }
        break;
      case 16: // cycle -> CYCLE, expr, statement
{ CurrentSemanticValue.stVal = new CycleNode(ValueStack[ValueStack.Depth-2].eVal, ValueStack[ValueStack.Depth-1].stVal); }
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
