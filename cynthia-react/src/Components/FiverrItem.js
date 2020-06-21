import React, { Component } from 'react';

export class FiverrItem extends Component {
    
    getStyle = () => {
        return {
            textDecoration: this.props.fiverrItem.bitIsDone ? 'line-through' : 'none',
            background: '#f3f3f3'
            
        }
    }

    markComplete = (e) => {
        e.bitIsDone = !e.bitIsDone;
        console.log('HAAAAAAAA' + e.bitIsDone)
    }

    render() {
        return (
            <div style={this.getStyle()}>
                <h5>ID: {this.props.fiverrItem.id} | Descrição: {this.props.fiverrItem.nvcDescription}</h5>
                <input type="checkbox" onChange={this.markComplete}/>
            </div>
        )
    }
}

export default FiverrItem;