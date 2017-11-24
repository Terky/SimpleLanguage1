// This code was generated by the Gardens Point Parser Generator
// Copyright (c) Wayne Kelly, QUT 2005-2010
// (see accompanying GPPGcopyright.rtf)

// GPPG version 1.3.6
// Machine:  DESKTOP-0KBKC6T
// DateTime: 11/24/2017 3:19:08 PM
// UserName: Coelum
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
    MULT=13,VAR=14,COLON=15,COMMA=16,RETURN=17,GT=18,
    LT=19,EQ=20,NEQ=21,GET=22,LET=23,AND=24,
    OR=25,NOT=26,IF=27,ELSE=28,WHILE=29,DO=30,
    FOR=31,INUM=32,DNUM=33,BVAL=34,ID=35};

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
            public DeclId declId;
            public DeclType declType;
			public FormalPaparms formParams;
			public List<ExprNode> eList;
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
  private static Rule[] rules = new Rule[72];
  private static State[] states = new State[131];
  private static string[] nonTerms = new string[] {
      "expr", "ident", "term", "factor", "function", "fun_list", "fun_call", 
      "b_expr", "b_term", "b_factor", "not_factor", "relation", "assign", "statement", 
      "decl", "return", "cond", "proc_call", "while_cycle", "do_while_cycle", 
      "for_cycle", "for_initializer", "for_statement", "stlist", "block", "fun_header", 
      "formal_params", "expr_list", "decl_id", "type", "progr", "$accept", "formal_params_fill", 
      };

  static Parser() {
    states[0] = new State(new int[]{35,127},new int[]{-31,1,-6,3,-5,130,-26,5,-30,117});
    states[1] = new State(new int[]{2,2});
    states[2] = new State(-1);
    states[3] = new State(new int[]{35,127,2,-2},new int[]{-5,4,-26,5,-30,117});
    states[4] = new State(-4);
    states[5] = new State(new int[]{3,7},new int[]{-25,6});
    states[6] = new State(-5);
    states[7] = new State(new int[]{35,65,27,69,3,7,17,81,29,87,30,94,31,101,7,110},new int[]{-24,8,-14,116,-13,11,-2,13,-17,68,-15,76,-25,78,-16,79,-18,83,-7,85,-19,86,-20,92,-21,100});
    states[8] = new State(new int[]{4,9,35,65,27,69,3,7,17,81,29,87,30,94,31,101,7,110},new int[]{-14,10,-13,11,-2,13,-17,68,-15,76,-25,78,-16,79,-18,83,-7,85,-19,86,-20,92,-21,100});
    states[9] = new State(-62);
    states[10] = new State(-13);
    states[11] = new State(new int[]{7,12});
    states[12] = new State(-14);
    states[13] = new State(new int[]{6,14});
    states[14] = new State(new int[]{34,21,10,30,35,39,32,47,33,48,26,49},new int[]{-8,15,-9,33,-11,34,-10,20,-12,22,-1,23,-3,35,-4,45,-2,38,-7,46});
    states[15] = new State(new int[]{25,16,7,-33,11,-33});
    states[16] = new State(new int[]{34,21,10,30,35,39,32,47,33,48,26,49},new int[]{-9,17,-11,34,-10,20,-12,22,-1,23,-3,35,-4,45,-2,38,-7,46});
    states[17] = new State(new int[]{24,18,25,-36,7,-36,11,-36,16,-36});
    states[18] = new State(new int[]{34,21,10,30,35,39,32,47,33,48,26,49},new int[]{-11,19,-10,20,-12,22,-1,23,-3,35,-4,45,-2,38,-7,46});
    states[19] = new State(-38);
    states[20] = new State(-40);
    states[21] = new State(-42);
    states[22] = new State(-43);
    states[23] = new State(new int[]{18,24,8,26,9,53,19,55,23,57,22,59,20,61,21,63,24,-50,25,-50,7,-50,11,-50,16,-50});
    states[24] = new State(new int[]{10,30,35,39,32,47,33,48},new int[]{-1,25,-3,35,-4,45,-2,38,-7,46});
    states[25] = new State(new int[]{8,26,9,53,24,-44,25,-44,7,-44,11,-44,16,-44});
    states[26] = new State(new int[]{10,30,35,39,32,47,33,48},new int[]{-3,27,-4,45,-2,38,-7,46});
    states[27] = new State(new int[]{13,28,12,36,18,-51,8,-51,9,-51,19,-51,23,-51,22,-51,20,-51,21,-51,24,-51,25,-51,7,-51,11,-51,16,-51});
    states[28] = new State(new int[]{10,30,35,39,32,47,33,48},new int[]{-4,29,-2,38,-7,46});
    states[29] = new State(-54);
    states[30] = new State(new int[]{34,21,10,30,35,39,32,47,33,48,26,49},new int[]{-8,31,-9,33,-11,34,-10,20,-12,22,-1,23,-3,35,-4,45,-2,38,-7,46});
    states[31] = new State(new int[]{11,32,25,16});
    states[32] = new State(-57);
    states[33] = new State(new int[]{24,18,25,-37,7,-37,11,-37,16,-37});
    states[34] = new State(-39);
    states[35] = new State(new int[]{13,28,12,36,18,-53,8,-53,9,-53,19,-53,23,-53,22,-53,20,-53,21,-53,24,-53,25,-53,7,-53,11,-53,16,-53});
    states[36] = new State(new int[]{10,30,35,39,32,47,33,48},new int[]{-4,37,-2,38,-7,46});
    states[37] = new State(-55);
    states[38] = new State(-58);
    states[39] = new State(new int[]{10,40,13,-31,12,-31,18,-31,8,-31,9,-31,19,-31,23,-31,22,-31,20,-31,21,-31,24,-31,25,-31,7,-31,11,-31,16,-31,6,-31});
    states[40] = new State(new int[]{11,51,34,21,10,30,35,39,32,47,33,48,26,49},new int[]{-28,41,-8,52,-9,33,-11,34,-10,20,-12,22,-1,23,-3,35,-4,45,-2,38,-7,46});
    states[41] = new State(new int[]{11,42,16,43});
    states[42] = new State(-27);
    states[43] = new State(new int[]{34,21,10,30,35,39,32,47,33,48,26,49},new int[]{-8,44,-9,33,-11,34,-10,20,-12,22,-1,23,-3,35,-4,45,-2,38,-7,46});
    states[44] = new State(new int[]{25,16,11,-30,16,-30});
    states[45] = new State(-56);
    states[46] = new State(-59);
    states[47] = new State(-60);
    states[48] = new State(-61);
    states[49] = new State(new int[]{34,21,10,30,35,39,32,47,33,48},new int[]{-10,50,-12,22,-1,23,-3,35,-4,45,-2,38,-7,46});
    states[50] = new State(-41);
    states[51] = new State(-28);
    states[52] = new State(new int[]{25,16,11,-29,16,-29});
    states[53] = new State(new int[]{10,30,35,39,32,47,33,48},new int[]{-3,54,-4,45,-2,38,-7,46});
    states[54] = new State(new int[]{13,28,12,36,18,-52,8,-52,9,-52,19,-52,23,-52,22,-52,20,-52,21,-52,24,-52,25,-52,7,-52,11,-52,16,-52});
    states[55] = new State(new int[]{10,30,35,39,32,47,33,48},new int[]{-1,56,-3,35,-4,45,-2,38,-7,46});
    states[56] = new State(new int[]{8,26,9,53,24,-45,25,-45,7,-45,11,-45,16,-45});
    states[57] = new State(new int[]{10,30,35,39,32,47,33,48},new int[]{-1,58,-3,35,-4,45,-2,38,-7,46});
    states[58] = new State(new int[]{8,26,9,53,24,-46,25,-46,7,-46,11,-46,16,-46});
    states[59] = new State(new int[]{10,30,35,39,32,47,33,48},new int[]{-1,60,-3,35,-4,45,-2,38,-7,46});
    states[60] = new State(new int[]{8,26,9,53,24,-47,25,-47,7,-47,11,-47,16,-47});
    states[61] = new State(new int[]{10,30,35,39,32,47,33,48},new int[]{-1,62,-3,35,-4,45,-2,38,-7,46});
    states[62] = new State(new int[]{8,26,9,53,24,-48,25,-48,7,-48,11,-48,16,-48});
    states[63] = new State(new int[]{10,30,35,39,32,47,33,48},new int[]{-1,64,-3,35,-4,45,-2,38,-7,46});
    states[64] = new State(new int[]{8,26,9,53,24,-49,25,-49,7,-49,11,-49,16,-49});
    states[65] = new State(new int[]{35,66,10,40,6,-31},new int[]{-13,67,-2,13});
    states[66] = new State(new int[]{7,-25,6,-31});
    states[67] = new State(-26);
    states[68] = new State(-15);
    states[69] = new State(new int[]{10,70});
    states[70] = new State(new int[]{34,21,10,30,35,39,32,47,33,48,26,49},new int[]{-8,71,-9,33,-11,34,-10,20,-12,22,-1,23,-3,35,-4,45,-2,38,-7,46});
    states[71] = new State(new int[]{11,72,25,16});
    states[72] = new State(new int[]{35,65,27,69,3,7,17,81,29,87,30,94,31,101,7,110},new int[]{-14,73,-13,11,-2,13,-17,68,-15,76,-25,78,-16,79,-18,83,-7,85,-19,86,-20,92,-21,100});
    states[73] = new State(new int[]{28,74,4,-35,35,-35,27,-35,3,-35,17,-35,29,-35,30,-35,31,-35,7,-35});
    states[74] = new State(new int[]{35,65,27,69,3,7,17,81,29,87,30,94,31,101,7,110},new int[]{-14,75,-13,11,-2,13,-17,68,-15,76,-25,78,-16,79,-18,83,-7,85,-19,86,-20,92,-21,100});
    states[75] = new State(-34);
    states[76] = new State(new int[]{7,77});
    states[77] = new State(-16);
    states[78] = new State(-17);
    states[79] = new State(new int[]{7,80});
    states[80] = new State(-18);
    states[81] = new State(new int[]{34,21,10,30,35,39,32,47,33,48,26,49,7,-71},new int[]{-8,82,-9,33,-11,34,-10,20,-12,22,-1,23,-3,35,-4,45,-2,38,-7,46});
    states[82] = new State(new int[]{25,16,7,-70});
    states[83] = new State(new int[]{7,84});
    states[84] = new State(-19);
    states[85] = new State(-24);
    states[86] = new State(-20);
    states[87] = new State(new int[]{10,88});
    states[88] = new State(new int[]{34,21,10,30,35,39,32,47,33,48,26,49},new int[]{-8,89,-9,33,-11,34,-10,20,-12,22,-1,23,-3,35,-4,45,-2,38,-7,46});
    states[89] = new State(new int[]{11,90,25,16});
    states[90] = new State(new int[]{35,65,27,69,3,7,17,81,29,87,30,94,31,101,7,110},new int[]{-14,91,-13,11,-2,13,-17,68,-15,76,-25,78,-16,79,-18,83,-7,85,-19,86,-20,92,-21,100});
    states[91] = new State(-63);
    states[92] = new State(new int[]{7,93});
    states[93] = new State(-21);
    states[94] = new State(new int[]{35,65,27,69,3,7,17,81,29,87,30,94,31,101,7,110},new int[]{-14,95,-13,11,-2,13,-17,68,-15,76,-25,78,-16,79,-18,83,-7,85,-19,86,-20,92,-21,100});
    states[95] = new State(new int[]{29,96});
    states[96] = new State(new int[]{10,97});
    states[97] = new State(new int[]{34,21,10,30,35,39,32,47,33,48,26,49},new int[]{-8,98,-9,33,-11,34,-10,20,-12,22,-1,23,-3,35,-4,45,-2,38,-7,46});
    states[98] = new State(new int[]{11,99,25,16});
    states[99] = new State(-64);
    states[100] = new State(-22);
    states[101] = new State(new int[]{10,102});
    states[102] = new State(new int[]{35,114},new int[]{-22,103,-15,113,-13,115,-2,13});
    states[103] = new State(new int[]{7,104});
    states[104] = new State(new int[]{34,21,10,30,35,39,32,47,33,48,26,49},new int[]{-8,105,-9,33,-11,34,-10,20,-12,22,-1,23,-3,35,-4,45,-2,38,-7,46});
    states[105] = new State(new int[]{7,106,25,16});
    states[106] = new State(new int[]{35,39},new int[]{-23,107,-13,111,-2,13,-18,112,-7,85});
    states[107] = new State(new int[]{11,108});
    states[108] = new State(new int[]{35,65,27,69,3,7,17,81,29,87,30,94,31,101,7,110},new int[]{-14,109,-13,11,-2,13,-17,68,-15,76,-25,78,-16,79,-18,83,-7,85,-19,86,-20,92,-21,100});
    states[109] = new State(-65);
    states[110] = new State(-23);
    states[111] = new State(-68);
    states[112] = new State(-69);
    states[113] = new State(-66);
    states[114] = new State(new int[]{35,66,6,-31},new int[]{-13,67,-2,13});
    states[115] = new State(-67);
    states[116] = new State(-12);
    states[117] = new State(new int[]{35,126},new int[]{-29,118});
    states[118] = new State(new int[]{10,119});
    states[119] = new State(new int[]{35,127,11,-9},new int[]{-27,120,-33,122,-30,128});
    states[120] = new State(new int[]{11,121});
    states[121] = new State(-7);
    states[122] = new State(new int[]{16,123,11,-8});
    states[123] = new State(new int[]{35,127},new int[]{-30,124});
    states[124] = new State(new int[]{35,126},new int[]{-29,125});
    states[125] = new State(-11);
    states[126] = new State(-6);
    states[127] = new State(-32);
    states[128] = new State(new int[]{35,126},new int[]{-29,129});
    states[129] = new State(-10);
    states[130] = new State(-3);

    rules[1] = new Rule(-32, new int[]{-31,2});
    rules[2] = new Rule(-31, new int[]{-6});
    rules[3] = new Rule(-6, new int[]{-5});
    rules[4] = new Rule(-6, new int[]{-6,-5});
    rules[5] = new Rule(-5, new int[]{-26,-25});
    rules[6] = new Rule(-29, new int[]{35});
    rules[7] = new Rule(-26, new int[]{-30,-29,10,-27,11});
    rules[8] = new Rule(-27, new int[]{-33});
    rules[9] = new Rule(-27, new int[]{});
    rules[10] = new Rule(-33, new int[]{-30,-29});
    rules[11] = new Rule(-33, new int[]{-33,16,-30,-29});
    rules[12] = new Rule(-24, new int[]{-14});
    rules[13] = new Rule(-24, new int[]{-24,-14});
    rules[14] = new Rule(-14, new int[]{-13,7});
    rules[15] = new Rule(-14, new int[]{-17});
    rules[16] = new Rule(-14, new int[]{-15,7});
    rules[17] = new Rule(-14, new int[]{-25});
    rules[18] = new Rule(-14, new int[]{-16,7});
    rules[19] = new Rule(-14, new int[]{-18,7});
    rules[20] = new Rule(-14, new int[]{-19});
    rules[21] = new Rule(-14, new int[]{-20,7});
    rules[22] = new Rule(-14, new int[]{-21});
    rules[23] = new Rule(-14, new int[]{7});
    rules[24] = new Rule(-18, new int[]{-7});
    rules[25] = new Rule(-15, new int[]{35,35});
    rules[26] = new Rule(-15, new int[]{35,-13});
    rules[27] = new Rule(-7, new int[]{35,10,-28,11});
    rules[28] = new Rule(-7, new int[]{35,10,11});
    rules[29] = new Rule(-28, new int[]{-8});
    rules[30] = new Rule(-28, new int[]{-28,16,-8});
    rules[31] = new Rule(-2, new int[]{35});
    rules[32] = new Rule(-30, new int[]{35});
    rules[33] = new Rule(-13, new int[]{-2,6,-8});
    rules[34] = new Rule(-17, new int[]{27,10,-8,11,-14,28,-14});
    rules[35] = new Rule(-17, new int[]{27,10,-8,11,-14});
    rules[36] = new Rule(-8, new int[]{-8,25,-9});
    rules[37] = new Rule(-8, new int[]{-9});
    rules[38] = new Rule(-9, new int[]{-9,24,-11});
    rules[39] = new Rule(-9, new int[]{-11});
    rules[40] = new Rule(-11, new int[]{-10});
    rules[41] = new Rule(-11, new int[]{26,-10});
    rules[42] = new Rule(-10, new int[]{34});
    rules[43] = new Rule(-10, new int[]{-12});
    rules[44] = new Rule(-12, new int[]{-1,18,-1});
    rules[45] = new Rule(-12, new int[]{-1,19,-1});
    rules[46] = new Rule(-12, new int[]{-1,23,-1});
    rules[47] = new Rule(-12, new int[]{-1,22,-1});
    rules[48] = new Rule(-12, new int[]{-1,20,-1});
    rules[49] = new Rule(-12, new int[]{-1,21,-1});
    rules[50] = new Rule(-12, new int[]{-1});
    rules[51] = new Rule(-1, new int[]{-1,8,-3});
    rules[52] = new Rule(-1, new int[]{-1,9,-3});
    rules[53] = new Rule(-1, new int[]{-3});
    rules[54] = new Rule(-3, new int[]{-3,13,-4});
    rules[55] = new Rule(-3, new int[]{-3,12,-4});
    rules[56] = new Rule(-3, new int[]{-4});
    rules[57] = new Rule(-4, new int[]{10,-8,11});
    rules[58] = new Rule(-4, new int[]{-2});
    rules[59] = new Rule(-4, new int[]{-7});
    rules[60] = new Rule(-4, new int[]{32});
    rules[61] = new Rule(-4, new int[]{33});
    rules[62] = new Rule(-25, new int[]{3,-24,4});
    rules[63] = new Rule(-19, new int[]{29,10,-8,11,-14});
    rules[64] = new Rule(-20, new int[]{30,-14,29,10,-8,11});
    rules[65] = new Rule(-21, new int[]{31,10,-22,7,-8,7,-23,11,-14});
    rules[66] = new Rule(-22, new int[]{-15});
    rules[67] = new Rule(-22, new int[]{-13});
    rules[68] = new Rule(-23, new int[]{-13});
    rules[69] = new Rule(-23, new int[]{-18});
    rules[70] = new Rule(-16, new int[]{17,-8});
    rules[71] = new Rule(-16, new int[]{17});
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
      case 6: // decl_id -> ID
{ CurrentSemanticValue.declId = new DeclIdNode(ValueStack[ValueStack.Depth-1].sVal); var loc = LocationStack[LocationStack.Depth-1]; }
        break;
      case 7: // fun_header -> type, decl_id, LEFT_BRACKET, formal_params, RIGHT_BRACKET
{ CurrentSemanticValue.fHead = new FunHeader(ValueStack[ValueStack.Depth-5].declType, ValueStack[ValueStack.Depth-4].declId, ValueStack[ValueStack.Depth-2].formParams); }
        break;
      case 8: // formal_params -> formal_params_fill
{ CurrentSemanticValue.formParams = ValueStack[ValueStack.Depth-1]; }
        break;
      case 10: // formal_params_fill -> type, decl_id
{ CurrentSemanticValue = new FormalParams(ValueStack[ValueStack.Depth-2].declType, ValueStack[ValueStack.Depth-1].declId); }
        break;
      case 11: // formal_params_fill -> formal_params_fill, COMMA, type, decl_id
{
		    ValueStack[ValueStack.Depth-4].Add(ValueStack[ValueStack.Depth-2].declType,ValueStack[ValueStack.Depth-1].declId);
			CurrentSemanticValue = ValueStack[ValueStack.Depth-4]; 
		}
        break;
      case 12: // stlist -> statement
{ CurrentSemanticValue.blVal = new BlockNode(ValueStack[ValueStack.Depth-1].stVal); }
        break;
      case 13: // stlist -> stlist, statement
{ 
		    if (ValueStack[ValueStack.Depth-1].stVal != null)
            {
			    ValueStack[ValueStack.Depth-2].blVal.Add(ValueStack[ValueStack.Depth-1].stVal);
            }
			CurrentSemanticValue.blVal = ValueStack[ValueStack.Depth-2].blVal; 
		}
        break;
      case 14: // statement -> assign, SEMICOLON
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-2].stVal; }
        break;
      case 15: // statement -> cond
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-1].stVal; }
        break;
      case 16: // statement -> decl, SEMICOLON
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-2].stVal; }
        break;
      case 17: // statement -> block
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-1].blVal; }
        break;
      case 18: // statement -> return, SEMICOLON
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-2].stVal; }
        break;
      case 19: // statement -> proc_call, SEMICOLON
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-2].stVal; }
        break;
      case 20: // statement -> while_cycle
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-1].stVal; }
        break;
      case 21: // statement -> do_while_cycle, SEMICOLON
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-2].stVal; }
        break;
      case 22: // statement -> for_cycle
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-1].stVal; }
        break;
      case 23: // statement -> SEMICOLON
{ CurrentSemanticValue.stVal = null; }
        break;
      case 24: // proc_call -> fun_call
{ CurrentSemanticValue.stVal = new ProcCallNode(ValueStack[ValueStack.Depth-1].eVal as FunCallNode); }
        break;
      case 25: // decl -> ID, ID
{ CurrentSemanticValue.stVal = new DeclNode(ValueStack[ValueStack.Depth-2].sVal, ValueStack[ValueStack.Depth-1].sVal); }
        break;
      case 26: // decl -> ID, assign
{ CurrentSemanticValue.stVal = new DeclNode(ValueStack[ValueStack.Depth-2].sVal, ValueStack[ValueStack.Depth-1].stVal as AssignNode); }
        break;
      case 27: // fun_call -> ID, LEFT_BRACKET, expr_list, RIGHT_BRACKET
{ CurrentSemanticValue.eVal = new FunCallNode(ValueStack[ValueStack.Depth-4].sVal, ValueStack[ValueStack.Depth-2].eList); }
        break;
      case 28: // fun_call -> ID, LEFT_BRACKET, RIGHT_BRACKET
{ CurrentSemanticValue.eVal = new FunCallNode(ValueStack[ValueStack.Depth-3].sVal); }
        break;
      case 29: // expr_list -> b_expr
{
            CurrentSemanticValue.eList = new List<ExprNode>();
		    CurrentSemanticValue.eList.Add(ValueStack[ValueStack.Depth-1].eVal);
        }
        break;
      case 30: // expr_list -> expr_list, COMMA, b_expr
{
		    ValueStack[ValueStack.Depth-3].eList.Add(ValueStack[ValueStack.Depth-1].eVal);
			CurrentSemanticValue.eList = ValueStack[ValueStack.Depth-3].eList; 
		}
        break;
      case 31: // ident -> ID
{ CurrentSemanticValue.eVal = new IdNode(ValueStack[ValueStack.Depth-1].sVal); }
        break;
      case 32: // type -> ID
{ CurrentSemanticValue.declType = new TypeNode(ValueStack[ValueStack.Depth-1].sVal, LocationStack[LocationStack.Depth-1]); }
        break;
      case 33: // assign -> ident, ASSIGN, b_expr
{ CurrentSemanticValue.stVal = new AssignNode(ValueStack[ValueStack.Depth-3].eVal as IdNode, ValueStack[ValueStack.Depth-1].eVal); }
        break;
      case 34: // cond -> IF, LEFT_BRACKET, b_expr, RIGHT_BRACKET, statement, ELSE, statement
{ CurrentSemanticValue.stVal = new CondNode(ValueStack[ValueStack.Depth-5].eVal, ValueStack[ValueStack.Depth-3].stVal, ValueStack[ValueStack.Depth-1].stVal); }
        break;
      case 35: // cond -> IF, LEFT_BRACKET, b_expr, RIGHT_BRACKET, statement
{ CurrentSemanticValue.stVal = new CondNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].stVal, null); }
        break;
      case 36: // b_expr -> b_expr, OR, b_term
{ CurrentSemanticValue.eVal = new BinExprNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, OpType.Or); }
        break;
      case 37: // b_expr -> b_term
{ CurrentSemanticValue.eVal = ValueStack[ValueStack.Depth-1].eVal; }
        break;
      case 38: // b_term -> b_term, AND, not_factor
{ CurrentSemanticValue.eVal = new BinExprNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, OpType.And); }
        break;
      case 39: // b_term -> not_factor
{ CurrentSemanticValue.eVal = ValueStack[ValueStack.Depth-1].eVal; }
        break;
      case 40: // not_factor -> b_factor
{ CurrentSemanticValue.eVal = ValueStack[ValueStack.Depth-1].eVal; }
        break;
      case 41: // not_factor -> NOT, b_factor
{ CurrentSemanticValue.eVal = new UnExprNode(ValueStack[ValueStack.Depth-1].eVal, OpType.Not); }
        break;
      case 42: // b_factor -> BVAL
{ CurrentSemanticValue.eVal = new BoolNode(ValueStack[ValueStack.Depth-1].bVal); }
        break;
      case 43: // b_factor -> relation
{ CurrentSemanticValue.eVal = ValueStack[ValueStack.Depth-1].eVal; }
        break;
      case 44: // relation -> expr, GT, expr
{ CurrentSemanticValue.eVal = new BinExprNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, OpType.Gt); }
        break;
      case 45: // relation -> expr, LT, expr
{ CurrentSemanticValue.eVal = new BinExprNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, OpType.Lt); }
        break;
      case 46: // relation -> expr, LET, expr
{ CurrentSemanticValue.eVal = new BinExprNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, OpType.Let); }
        break;
      case 47: // relation -> expr, GET, expr
{ CurrentSemanticValue.eVal = new BinExprNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, OpType.Get); }
        break;
      case 48: // relation -> expr, EQ, expr
{ CurrentSemanticValue.eVal = new BinExprNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, OpType.Eq); }
        break;
      case 49: // relation -> expr, NEQ, expr
{ CurrentSemanticValue.eVal = new BinExprNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, OpType.Neq); }
        break;
      case 50: // relation -> expr
{ CurrentSemanticValue.eVal = ValueStack[ValueStack.Depth-1].eVal; }
        break;
      case 51: // expr -> expr, PLUS, term
{ CurrentSemanticValue.eVal = new BinExprNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, OpType.Plus); }
        break;
      case 52: // expr -> expr, MINUS, term
{ CurrentSemanticValue.eVal = new BinExprNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, OpType.Minus); }
        break;
      case 53: // expr -> term
{ CurrentSemanticValue.eVal = ValueStack[ValueStack.Depth-1].eVal; }
        break;
      case 54: // term -> term, MULT, factor
{ CurrentSemanticValue.eVal = new BinExprNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, OpType.Mult); }
        break;
      case 55: // term -> term, DIV, factor
{ CurrentSemanticValue.eVal = new BinExprNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, OpType.Div); }
        break;
      case 56: // term -> factor
{ CurrentSemanticValue.eVal = ValueStack[ValueStack.Depth-1].eVal; }
        break;
      case 57: // factor -> LEFT_BRACKET, b_expr, RIGHT_BRACKET
{ CurrentSemanticValue.eVal = ValueStack[ValueStack.Depth-2].eVal; }
        break;
      case 58: // factor -> ident
{ CurrentSemanticValue.eVal = ValueStack[ValueStack.Depth-1].eVal as IdNode; }
        break;
      case 59: // factor -> fun_call
{ CurrentSemanticValue.eVal = ValueStack[ValueStack.Depth-1].eVal as FunCallNode; }
        break;
      case 60: // factor -> INUM
{ CurrentSemanticValue.eVal = new IntNumNode(ValueStack[ValueStack.Depth-1].iVal); }
        break;
      case 61: // factor -> DNUM
{ CurrentSemanticValue.eVal = new DoubleNumNode(ValueStack[ValueStack.Depth-1].dVal); }
        break;
      case 62: // block -> BEGIN, stlist, END
{ CurrentSemanticValue.blVal = ValueStack[ValueStack.Depth-2].blVal; }
        break;
      case 63: // while_cycle -> WHILE, LEFT_BRACKET, b_expr, RIGHT_BRACKET, statement
{ CurrentSemanticValue.stVal = new WhileNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].stVal); }
        break;
      case 64: // do_while_cycle -> DO, statement, WHILE, LEFT_BRACKET, b_expr, RIGHT_BRACKET
{ CurrentSemanticValue.stVal = new DoWhileNode(ValueStack[ValueStack.Depth-2].eVal, ValueStack[ValueStack.Depth-5].stVal); }
        break;
      case 65: // for_cycle -> FOR, LEFT_BRACKET, for_initializer, SEMICOLON, b_expr, SEMICOLON, 
               //              for_statement, RIGHT_BRACKET, statement
{
            CurrentSemanticValue.stVal = new ForNode(ValueStack[ValueStack.Depth-7].stVal, ValueStack[ValueStack.Depth-5].eVal, ValueStack[ValueStack.Depth-3].stVal, ValueStack[ValueStack.Depth-1].stVal);
        }
        break;
      case 66: // for_initializer -> decl
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-1].stVal; }
        break;
      case 67: // for_initializer -> assign
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-1].stVal; }
        break;
      case 68: // for_statement -> assign
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-1].stVal; }
        break;
      case 69: // for_statement -> proc_call
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-1].stVal; }
        break;
      case 70: // return -> RETURN, b_expr
{ CurrentSemanticValue.stVal = new ReturnNode(ValueStack[ValueStack.Depth-1].eVal); }
        break;
      case 71: // return -> RETURN
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
